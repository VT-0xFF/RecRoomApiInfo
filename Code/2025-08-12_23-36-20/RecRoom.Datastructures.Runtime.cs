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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83496D0", Offset = "0x83484D0", VA = "0x1883496D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LMMHPMMJDBK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23B06A0", Offset = "0x23AF4A0", VA = "0x1823B06A0")]
	public LMMHPMMJDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, KGHOEDFHBHK, IDNIAHPHMNP, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HOHPDECNKDA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
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
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x834AA50", Offset = "0x8349850", VA = "0x18834AA50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x834AA10", Offset = "0x8349810", VA = "0x18834AA10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x834AA90", Offset = "0x8349890", VA = "0x18834AA90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x834AC40", Offset = "0x8349A40", VA = "0x18834AC40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x834ABB0", Offset = "0x83499B0", VA = "0x18834ABB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAE7AE0", Offset = "0xAE68E0", VA = "0x180AE7AE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAE79E0", Offset = "0xAE67E0", VA = "0x180AE79E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x834A9D0", Offset = "0x83497D0", VA = "0x18834A9D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x834AB20", Offset = "0x8349920", VA = "0x18834AB20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x834A470", Offset = "0x8349270", VA = "0x18834A470")]
	public void CopyBounds(SavedExtents FGAEAFBDBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x834A920", Offset = "0x8349720", VA = "0x18834A920")]
	public void SetLocalSpaceBounds(Bounds GEANHFFPIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x16E5DC0", Offset = "0x16E4BC0", VA = "0x1816E5DC0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x834A910", Offset = "0x8349710", VA = "0x18834A910")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x834A4A0", Offset = "0x83492A0", VA = "0x18834A4A0")]
	private void DBIALKFJHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x834A710", Offset = "0x8349510", VA = "0x18834A710")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8349E30", Offset = "0x8348C30", VA = "0x188349E30")]
	public static void CalculateLocalBoundsFor(GameObject DFFAMKHOIDB, [Out] Bounds GEANHFFPIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x834A650", Offset = "0x8349450", VA = "0x18834A650")]
	private static void ONLIIDICAOO(Bounds KMNEIBIPMKI, Color JMOOEAFLFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x834A940", Offset = "0x8349740", VA = "0x18834A940")]
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
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1BA7710", Offset = "0x1BA6510", VA = "0x181BA7710")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E32020", Offset = "0x5E30E20", VA = "0x185E32020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public virtual void BLJEGNOGEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
	[LMMHPMMJDBK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E31C00", Offset = "0x5E30A00", VA = "0x185E31C00", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E308F0", Offset = "0x5E2F6F0", VA = "0x185E308F0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E31F70", Offset = "0x5E30D70", VA = "0x185E31F70")]
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
	private sealed class PHEFBEPIKKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PHEFBEPIKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BFB250", Offset = "0x5BFA050", VA = "0x185BFB250")]
		internal int FDDAPIFIAEF(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[LMMHPMMJDBK]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4A81730", Offset = "0x4A80530", VA = "0x184A81730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4A81780", Offset = "0x4A80580", VA = "0x184A81780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4A81630", Offset = "0x4A80430", VA = "0x184A81630", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey OPGJHIOADCK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4A816D0", Offset = "0x4A804D0", VA = "0x184A816D0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4A81510", Offset = "0x4A80310", VA = "0x184A81510", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4A81220", Offset = "0x4A80020", VA = "0x184A81220", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4A80660", Offset = "0x4A7F460", VA = "0x184A80660", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4A80630", Offset = "0x4A7F430", VA = "0x184A80630", Slot = "14")]
	protected virtual string IMLFIAIOCBF(TKeyVal MFPABLKNCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A804E0", Offset = "0x4A7F2E0", VA = "0x184A804E0", Slot = "4")]
	public bool ContainsKey(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A813D0", Offset = "0x4A801D0", VA = "0x184A813D0", Slot = "5")]
	public bool TryGetValue(TKey OPGJHIOADCK, [Out] TVal HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4A80530", Offset = "0x4A7F330", VA = "0x184A80530", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A80530", Offset = "0x4A7F330", VA = "0x184A80530", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A81420", Offset = "0x4A80220", VA = "0x184A81420")]
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
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
		[Cpp2IlInjected.Address(RVA = "0x45B1FD0", Offset = "0x45B0DD0", VA = "0x1845B1FD0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[LMMHPMMJDBK]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E33800", Offset = "0x5E32600", VA = "0x185E33800")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E330C0", Offset = "0x5E31EC0", VA = "0x185E330C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5E326B0", Offset = "0x5E314B0", VA = "0x185E326B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class EAPEABICPIC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct LMGHAHHGAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T DDHBFJGPDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float OJANKLJLDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int CIEDLLIIEIK = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float ONGHOCPFKEN = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly LMGHAHHGAAO[] ELLFIONNNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int KFDIMNKKAHJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float FLGFFMMOGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD80840", Offset = "0xD7F640", VA = "0x180D80840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDF0080", Offset = "0xDEEE80", VA = "0x180DF0080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T IPEPFKPCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A383D0", Offset = "0x4A371D0", VA = "0x184A383D0")]
	protected EAPEABICPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4A383F0", Offset = "0x4A371F0", VA = "0x184A383F0")]
	protected EAPEABICPIC(int BCMFMCHGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4A38200", Offset = "0x4A37000", VA = "0x184A38200")]
	public void DPHJBDIDPOG(float GJEDFMHCPFI, T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool ICHONEHAGLP(float FNCCBDMLILN, float MAEDMBKLJNJ, [Out] T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool CMDGHEJODKJ(float FNCCBDMLILN, float MAEDMBKLJNJ, [Out] T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4A382F0", Offset = "0x4A370F0", VA = "0x184A382F0")]
	public void FMJEOCFJDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NMCMOFLAJAC : EAPEABICPIC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8349530", Offset = "0x8348330", VA = "0x188349530", Slot = "4")]
	public override bool ICHONEHAGLP(float FNCCBDMLILN, float MAEDMBKLJNJ, [Out] Vector3 HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x83493F0", Offset = "0x83481F0", VA = "0x1883493F0", Slot = "5")]
	public override bool CMDGHEJODKJ(float FNCCBDMLILN, float MAEDMBKLJNJ, [Out] Vector3 HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8349690", Offset = "0x8348490", VA = "0x188349690")]
	public NMCMOFLAJAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NPGLKGHPFGB
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E7FB60", Offset = "0x3E7E960", VA = "0x183E7FB60")]
	public static OGJHBMKKKLB<T1, T2> INIHOJCCLPM<T1, T2>(T1 OFBGHCBLJGF, T2 DHDGCEOCKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E7FBE0", Offset = "0x3E7E9E0", VA = "0x183E7FBE0")]
	public static FNGKNODJKPL<T1, T2, T3> INIHOJCCLPM<T1, T2, T3>(T1 OFBGHCBLJGF, T2 DHDGCEOCKGP, T3 AFPBIGIDJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5937ED0", Offset = "0x5936CD0", VA = "0x185937ED0")]
	internal static int OEIMIPPMIBH(int MGNOBBMDEIB, int GIKHPMHBFHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74C6D70", Offset = "0x74C5B70", VA = "0x1874C6D70")]
	internal static int OEIMIPPMIBH(int MGNOBBMDEIB, int GIKHPMHBFHO, int FJALCNIJAHE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OGJHBMKKKLB<T1, T2> : IComparable<OGJHBMKKKLB<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 HIGLABMGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 PDOPEBDACPB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5AC11C0", Offset = "0x5ABFFC0", VA = "0x185AC11C0")]
	public OGJHBMKKKLB(T1 OFBGHCBLJGF, T2 DHDGCEOCKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5AC0D60", Offset = "0x5ABFB60", VA = "0x185AC0D60", Slot = "4")]
	public int CompareTo(OGJHBMKKKLB<T1, T2> FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5AC0E50", Offset = "0x5ABFC50", VA = "0x185AC0E50", Slot = "0")]
	public override bool Equals(object FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5AC1010", Offset = "0x5ABFE10", VA = "0x185AC1010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5AC1060", Offset = "0x5ABFE60", VA = "0x185AC1060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FNGKNODJKPL<T1, T2, T3> : IComparable<FNGKNODJKPL<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 HIGLABMGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 PDOPEBDACPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 OPEHDAINBDO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4F31FF0", Offset = "0x4F30DF0", VA = "0x184F31FF0")]
	public FNGKNODJKPL(T1 OFBGHCBLJGF, T2 DHDGCEOCKGP, T3 AFPBIGIDJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4F31690", Offset = "0x4F30490", VA = "0x184F31690", Slot = "4")]
	public int CompareTo(FNGKNODJKPL<T1, T2, T3> FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4F31910", Offset = "0x4F30710", VA = "0x184F31910", Slot = "0")]
	public override bool Equals(object FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4F31C80", Offset = "0x4F30A80", VA = "0x184F31C80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4F31E30", Offset = "0x4F30C30", VA = "0x184F31E30", Slot = "3")]
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
	public AnimationCurve MOJHCHKBAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T JLGPEAPCDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x141B2F0", Offset = "0x141A0F0", VA = "0x18141B2F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T IIGEHACOAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2F08D60", Offset = "0x2F07B60", VA = "0x182F08D60")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2F089F0", Offset = "0x2F077F0", VA = "0x182F089F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GKGDODHFGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAE8A00", Offset = "0xAE7800", VA = "0x180AE8A00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6113C70", Offset = "0x6112A70", VA = "0x186113C70")]
	public T APOAACDACNI(float DDCPKPIHIOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61140F0", Offset = "0x6112EF0", VA = "0x1861140F0")]
	public T DDMKGHBHPNI(float DDCPKPIHIOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CLCDPOPAFKG(T CHAEOFDBIAH, T EBEGEKLHGJL, float DDCPKPIHIOM);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8348210", Offset = "0x8347010", VA = "0x188348210", Slot = "4")]
	protected override float CLCDPOPAFKG(float CHAEOFDBIAH, float EBEGEKLHGJL, float DDCPKPIHIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8348250", Offset = "0x8347050", VA = "0x188348250")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x19FDF30", Offset = "0x19FCD30", VA = "0x1819FDF30", Slot = "4")]
	protected override Vector3 CLCDPOPAFKG(Vector3 CHAEOFDBIAH, Vector3 EBEGEKLHGJL, float DDCPKPIHIOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x834BA40", Offset = "0x834A840", VA = "0x18834BA40")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8347DB0", Offset = "0x8346BB0", VA = "0x188347DB0", Slot = "4")]
	protected override Color CLCDPOPAFKG(Color CHAEOFDBIAH, Color EBEGEKLHGJL, float DDCPKPIHIOM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8347E70", Offset = "0x8346C70", VA = "0x188347E70")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LEKMCHIJEFL : EOCLFJJIBDB<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8349110", Offset = "0x8347F10", VA = "0x188349110")]
	public LEKMCHIJEFL(int FIBLEJKLMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x83490A0", Offset = "0x8347EA0", VA = "0x1883490A0", Slot = "6")]
	protected override uint MAFILIMEBOO(uint HOHPDECNKDA, string HGMAIPELJHM)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PKMCIFDENCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable MOIOIMEFPHA;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PKMCIFDENCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BAHPHJAHLOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> LDABNNFDJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LCEOONPICEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ACGHJKDILGN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x58BB3C0", Offset = "0x58BA1C0", VA = "0x1858BB3C0")]
	private BAHPHJAHLOK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KFJDCKELDHB, int KNBPMAKBNDB, int OIBDIAPGEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x65F8990", Offset = "0x65F7790", VA = "0x1865F8990")]
	public static BAHPHJAHLOK<T> ELDPFIHNJDG()
	{
		return default(BAHPHJAHLOK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x65F9ED0", Offset = "0x65F8CD0", VA = "0x1865F9ED0")]
	public (int, int, Task<T>) MLEEDOCIDGH(int DGMBCDDJKOF, [Optional] CancellationToken BKHGNHANFKK, double KBODPDIPNAF = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x65FA590", Offset = "0x65F9390", VA = "0x1865FA590")]
	public void OOKGKKCNCLF(int DGMBCDDJKOF, int OIBDIAPGEMI, [In] T MOBFLOHJOKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PLCALDAHDKC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8349830", Offset = "0x8348630", VA = "0x188349830")]
	public static BAHPHJAHLOK<GFJAPJIFDGB> ELDPFIHNJDG()
	{
		return default(BAHPHJAHLOK<GFJAPJIFDGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8349880", Offset = "0x8348680", VA = "0x188349880")]
	public static void OOKGKKCNCLF([In] this BAHPHJAHLOK<GFJAPJIFDGB> DBBEADIHLKO, int DGMBCDDJKOF, int OIBDIAPGEMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class BEBAECJLFAM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> MMAJMFINHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> CIAFBGOLLOK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4516A90", Offset = "0x4515890", VA = "0x184516A90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MCPDIAGDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JDFHDDCJEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4F08A50", Offset = "0x4F07850", VA = "0x184F08A50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> BPHFEJAHHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6602BA0", Offset = "0x66019A0", VA = "0x186602BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6602AC0", Offset = "0x66018C0", VA = "0x186602AC0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6602C00", Offset = "0x6601A00", VA = "0x186602C00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66019F0", Offset = "0x66007F0", VA = "0x1866019F0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6601CF0", Offset = "0x6600AF0", VA = "0x186601CF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6602840", Offset = "0x6601640", VA = "0x186602840", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6601C00", Offset = "0x6600A00", VA = "0x186601C00", Slot = "9")]
	public void Add(TKey OPGJHIOADCK, TVal HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6601B60", Offset = "0x6600960", VA = "0x186601B60", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6601DB0", Offset = "0x6600BB0", VA = "0x186601DB0", Slot = "8")]
	public bool ContainsKey(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6601DF0", Offset = "0x6600BF0", VA = "0x186601DF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6602760", Offset = "0x6601560", VA = "0x186602760", Slot = "10")]
	public bool Remove(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6602790", Offset = "0x6601590", VA = "0x186602790", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6602930", Offset = "0x6601730", VA = "0x186602930", Slot = "11")]
	public bool TryGetValue(TKey OPGJHIOADCK, [Out] TVal HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x66022A0", Offset = "0x66010A0", VA = "0x1866022A0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6601EA0", Offset = "0x6600CA0", VA = "0x186601EA0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ELLFIONNNHC, int JIAHMCCMBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6601CA0", Offset = "0x6600AA0", VA = "0x186601CA0")]
	public bool CFOKPIKBEGL(TVal OPGJHIOADCK, [Out] TKey HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x66024B0", Offset = "0x66012B0", VA = "0x1866024B0")]
	private void MAGGMOPKCAL(TKey OPGJHIOADCK, TVal DOMECMGKIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6602550", Offset = "0x6601350", VA = "0x186602550")]
	private void PHAANFAIEMH(TKey OPGJHIOADCK, TVal DOMECMGKIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6601FF0", Offset = "0x6600DF0", VA = "0x186601FF0")]
	private bool ENMCGJLCNCL(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x66029D0", Offset = "0x66017D0", VA = "0x1866029D0")]
	public BEBAECJLFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class MDLJLDHBBAC<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private MDLJLDHBBAC<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x15289C0", Offset = "0x15277C0", VA = "0x1815289C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x4AEEAC0", Offset = "0x4AED8C0", VA = "0x184AEEAC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4AEF150", Offset = "0x4AEDF50", VA = "0x184AEF150")]
		public Enumerator(MDLJLDHBBAC<T> ALPKAMHLIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4AEC5E0", Offset = "0x4AEB3E0", VA = "0x184AEC5E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4AED740", Offset = "0x4AEC540", VA = "0x184AED740", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4AED430", Offset = "0x4AEC230", VA = "0x184AED430")]
		private void OKINAPIFMBL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] EIJDIHIGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int DOCKBMMINED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int AOHJJOBFDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HNEGIKALKJG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x589DB50", Offset = "0x589C950", VA = "0x18589DB50", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x589ACA0", Offset = "0x5899AA0", VA = "0x18589ACA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x589A9E0", Offset = "0x58997E0", VA = "0x18589A9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x589DAD0", Offset = "0x589C8D0", VA = "0x18589DAD0")]
	public MDLJLDHBBAC(int FIBLEJKLMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x589B210", Offset = "0x589A010", VA = "0x18589B210")]
	public void DPHJBDIDPOG(T DDCPKPIHIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x589C0C0", Offset = "0x589AEC0", VA = "0x18589C0C0")]
	public void GLPBDGMBMAM(IEnumerable<T> JBEBIIPBGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x589B310", Offset = "0x589A110", VA = "0x18589B310")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x589AD30", Offset = "0x5899B30", VA = "0x18589AD30")]
	public void CFLKCHNJJNH(int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x589D0B0", Offset = "0x589BEB0", VA = "0x18589D0B0")]
	public void PHBHCKKHAEI(T[] ELLFIONNNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x589CE50", Offset = "0x589BC50", VA = "0x18589CE50")]
	public Enumerator OLGNAIIDMLF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x589DA20", Offset = "0x589C820", VA = "0x18589DA20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x589DA20", Offset = "0x589C820", VA = "0x18589DA20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x589CAB0", Offset = "0x589B8B0", VA = "0x18589CAB0")]
	private int KKPFEKKINEO(int JJJJBEGKNIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x589CDE0", Offset = "0x589BBE0", VA = "0x18589CDE0")]
	private int OIOIMAJLOPD(int JJJJBEGKNIN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KODEPIGHBEG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> IDJAELFLDKJ(TRequest FGKGCIHOGKN, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum CCPGBEDBDGF
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class DDCICEPLIIM
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float HGMLIIKCDKN = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan KGFHFAAGNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int EHLNMKMEBKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CCPGBEDBDGF AIJGKEMKLEI;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly DDCICEPLIIM HANIMDCJEMB;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float LGPGKGOEHCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x4531340", Offset = "0x4530140", VA = "0x184531340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan HKIHOJKBCEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4531490", Offset = "0x4530290", VA = "0x184531490")]
		public DDCICEPLIIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct EILLLMEJFDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest FGKGCIHOGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken BKHGNHANFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> LHCEDHGBOJH;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4A60FF0", Offset = "0x4A5FDF0", VA = "0x184A60FF0")]
		public EILLLMEJFDM(TRequest FGKGCIHOGKN, TaskCompletionSource<TResult> LHCEDHGBOJH, CancellationToken BKHGNHANFKK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct KBOKOMPCDHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public KODEPIGHBEG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5566DF0", Offset = "0x5565BF0", VA = "0x185566DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x55679F0", Offset = "0x55667F0", VA = "0x1855679F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct MEOBMAJKLIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public KODEPIGHBEG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private EILLLMEJFDM <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x589E6F0", Offset = "0x589D4F0", VA = "0x18589E6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x589F930", Offset = "0x589E730", VA = "0x18589F930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource BMEFMFBPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<EILLLMEJFDM> FHIEEKPNKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DDCICEPLIIM AAJEGHNIILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IDJAELFLDKJ PJIBJHFBJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task BHDFIPHPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int KAIFCOKGIAL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x55F8620", Offset = "0x55F7420", VA = "0x1855F8620")]
	public KODEPIGHBEG(IDJAELFLDKJ PJIBJHFBJPH, [Optional] DDCICEPLIIM AAJEGHNIILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55F82B0", Offset = "0x55F70B0", VA = "0x1855F82B0")]
	public Task<TResult> MFKKBPEDGJC(TRequest FGKGCIHOGKN, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x55F6F50", Offset = "0x55F5D50", VA = "0x1855F6F50")]
	private void EMAAKDANGJG(EILLLMEJFDM PMCGBAPCNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x55F7BF0", Offset = "0x55F69F0", VA = "0x1855F7BF0")]
	[AsyncStateMachine(typeof(KODEPIGHBEG<, >.KBOKOMPCDHC))]
	private Task KKAPCMCMJOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x55F73F0", Offset = "0x55F61F0", VA = "0x1855F73F0")]
	private EILLLMEJFDM IIKMOBOMDHB()
	{
		return default(EILLLMEJFDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x55F7B00", Offset = "0x55F6900", VA = "0x1855F7B00")]
	[AsyncStateMachine(typeof(KODEPIGHBEG<, >.MEOBMAJKLIH))]
	private Task KFFHDEIELDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x55F6E20", Offset = "0x55F5C20", VA = "0x1855F6E20")]
	private void ABGCIADFGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x55F6F10", Offset = "0x55F5D10", VA = "0x1855F6F10", Slot = "4")]
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
public class KDGMDCBLEGL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> NGGCNGNMEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> KAIEMJAGEND;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4516A90", Offset = "0x4515890", VA = "0x184516A90", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MCPDIAGDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4F17CB0", Offset = "0x4F16AB0", VA = "0x184F17CB0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x55C5CE0", Offset = "0x55C4AE0", VA = "0x1855C5CE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x452C0E0", Offset = "0x452AEE0", VA = "0x18452C0E0", Slot = "11")]
	public void Add(T IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x55C5440", Offset = "0x55C4240", VA = "0x1855C5440")]
	public bool AKPHBPJOEJB(T IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x55C59D0", Offset = "0x55C47D0", VA = "0x1855C59D0", Slot = "15")]
	public bool Remove(T IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x54BC720", Offset = "0x54BB520", VA = "0x1854BC720", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4FA73C0", Offset = "0x4FA61C0", VA = "0x184FA73C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55C5500", Offset = "0x55C4300", VA = "0x1855C5500", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55C5560", Offset = "0x55C4360", VA = "0x1855C5560", Slot = "13")]
	public bool Contains(T IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55C55A0", Offset = "0x55C43A0", VA = "0x1855C55A0", Slot = "14")]
	public void CopyTo(T[] ELLFIONNNHC, int JIAHMCCMBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55C55D0", Offset = "0x55C43D0", VA = "0x1855C55D0", Slot = "6")]
	public int IndexOf(T IIHDHELGAFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55C5620", Offset = "0x55C4420", VA = "0x1855C5620", Slot = "7")]
	public void Insert(int JJJJBEGKNIN, T IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55C58E0", Offset = "0x55C46E0", VA = "0x1855C58E0", Slot = "8")]
	public void RemoveAt(int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55C5B10", Offset = "0x55C4910", VA = "0x1855C5B10")]
	public KDGMDCBLEGL()
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
			[Cpp2IlInjected.Address(RVA = "0x2D5FE90", Offset = "0x2D5EC90", VA = "0x182D5FE90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x834AFE0", Offset = "0x8349DE0", VA = "0x18834AFE0")]
		public SerializedGuid([In] Guid NMEMPCKPCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x834AE50", Offset = "0x8349C50", VA = "0x18834AE50")]
		public static SerializedGuid LDPNHIBAKHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x834ADD0", Offset = "0x8349BD0", VA = "0x18834ADD0")]
		public static SerializedGuid FGPMKAJBOOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x834AED0", Offset = "0x8349CD0", VA = "0x18834AED0")]
		public bool MJLOMDJHNBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x834AFB0", Offset = "0x8349DB0", VA = "0x18834AFB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x834AF30", Offset = "0x8349D30", VA = "0x18834AF30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x834AD00", Offset = "0x8349B00", VA = "0x18834AD00", Slot = "7")]
		public bool Equals(SerializedGuid FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x834AD40", Offset = "0x8349B40", VA = "0x18834AD40", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x834AE40", Offset = "0x8349C40", VA = "0x18834AE40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x834ACD0", Offset = "0x8349AD0", VA = "0x18834ACD0", Slot = "6")]
		public int CompareTo(SerializedGuid FGAEAFBDBPK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OHKKGOLOMGE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type BPJPLGDJFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string GBLBAIANBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool ELMIGLMHCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool CMEAFCCJBEE;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8349750", Offset = "0x8348550", VA = "0x188349750")]
	public OHKKGOLOMGE(Type AGONAEOMDKI, string BKEEGLMPCMD, bool NJBJHIBPMJD = false, bool DOJBEDBJGNN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LBAIIGGMKGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int GNKKBJCGMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> DLHEAAONMGI(float GJEDFMHCPFI, [Optional] float? PMMHCKEBDNI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDHLOFAFKDM(float GJEDFMHCPFI, T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMJEOCFJDAJ();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class GPBECOCAMFJ<T> : LBAIIGGMKGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class JJDCAJCEMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float EKCKINLNALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T DDHBFJGPDAJ;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JJDCAJCEMEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KCCPJFCKLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KCCPJFCKLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5569EC0", Offset = "0x5568CC0", VA = "0x185569EC0")]
		internal bool BHIHDDLMILA(JJDCAJCEMEN sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float FLPFNNHBOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float AKDKNMIEDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<JJDCAJCEMEN> KNIGABCLPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private FIPFPHMIMGE<JJDCAJCEMEN> FFDGPFNLJCF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GNKKBJCGMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x50103E0", Offset = "0x500F1E0", VA = "0x1850103E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x50104C0", Offset = "0x500F2C0", VA = "0x1850104C0")]
	public GPBECOCAMFJ(float EKPEAILDKLO, float MNJJPBHOCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x50100D0", Offset = "0x500EED0", VA = "0x1850100D0", Slot = "6")]
	public bool JDHLOFAFKDM(float GJEDFMHCPFI, T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x500FD40", Offset = "0x500EB40", VA = "0x18500FD40", Slot = "5")]
	public IEnumerable<T> DLHEAAONMGI(float GJEDFMHCPFI, float? PMMHCKEBDNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5010060", Offset = "0x500EE60", VA = "0x185010060", Slot = "7")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x500F8C0", Offset = "0x500E6C0", VA = "0x18500F8C0")]
	private void AOKBANDILMD(float GJEDFMHCPFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class NBCELKEFDHA<T> : LBAIIGGMKGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct MIJCOGPOHDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T DDHBFJGPDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float EKCKINLNALO;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x566B9F0", Offset = "0x566A7F0", VA = "0x18566B9F0")]
		public MIJCOGPOHDG(T HGMAIPELJHM, float GJEDFMHCPFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OOBJFNGPAJI : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public NBCELKEFDHA<T> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public OOBJFNGPAJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B2AC80", Offset = "0x5B29A80", VA = "0x185B2AC80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5B2B180", Offset = "0x5B29F80", VA = "0x185B2B180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5B2AFB0", Offset = "0x5B29DB0", VA = "0x185B2AFB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x51A3860", Offset = "0x51A2660", VA = "0x1851A3860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float EKPEAILDKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float MNJJPBHOCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<MIJCOGPOHDG> KNIGABCLPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int DOCKBMMINED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int DMLOAPBBNDH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int GNKKBJCGMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x595DBA0", Offset = "0x595C9A0", VA = "0x18595DBA0")]
	public NBCELKEFDHA(float EKPEAILDKLO, float MNJJPBHOCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x595D760", Offset = "0x595C560", VA = "0x18595D760", Slot = "6")]
	public bool JDHLOFAFKDM(float GJEDFMHCPFI, T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x595D9D0", Offset = "0x595C7D0", VA = "0x18595D9D0", Slot = "8")]
	public int NNNKKPCBCFG(float GJEDFMHCPFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x595D410", Offset = "0x595C210", VA = "0x18595D410", Slot = "5")]
	[IteratorStateMachine(typeof(NBCELKEFDHA<>.OOBJFNGPAJI))]
	public IEnumerable<T> DLHEAAONMGI(float GJEDFMHCPFI, float? PMMHCKEBDNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x595D4C0", Offset = "0x595C2C0", VA = "0x18595D4C0", Slot = "7")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x595DAC0", Offset = "0x595C8C0", VA = "0x18595DAC0")]
	private void PPJKCCFABKI(float GJEDFMHCPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x595D200", Offset = "0x595C000", VA = "0x18595D200")]
	private MIJCOGPOHDG CDAMOOBDIBK()
	{
		return default(MIJCOGPOHDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class GMHMEBHNAOE<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct NBIAGJLHLIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long EGNGEFNCFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long KMEKDIHLMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int MCINEAINKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int EONAHAKPFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool DFHDOCGKEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string LBCBKPKPFDC;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x59636B0", Offset = "0x59624B0", VA = "0x1859636B0")]
		public NBIAGJLHLIA(long EGNGEFNCFLL, int MCINEAINKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5963720", Offset = "0x5962520", VA = "0x185963720")]
		public NBIAGJLHLIA(long EGNGEFNCFLL, long KMEKDIHLMMF, int MCINEAINKBA, int EONAHAKPFHE, bool DFHDOCGKEFB, string LBCBKPKPFDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x59635E0", Offset = "0x59623E0", VA = "0x1859635E0")]
		public int GIPOKLDFJAE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5963690", Offset = "0x5962490", VA = "0x185963690")]
		public int JPPMOABDOEP(int KBKECAJMKJC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5963630", Offset = "0x5962430", VA = "0x185963630")]
		public double IKLNBPNCIIK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5963540", Offset = "0x5962340", VA = "0x185963540")]
		public NBIAGJLHLIA FFMEAKNGPJN(long KMEKDIHLMMF, int EONAHAKPFHE)
		{
			return default(NBIAGJLHLIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class HGELJMPBEBF : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct KAMHHBIKNOJ<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public HGELJMPBEBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<HGELJMPBEBF, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private HGELJMPBEBF <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x55631D0", Offset = "0x5561FD0", VA = "0x1855631D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4A7BDB0", Offset = "0x4A7ABB0", VA = "0x184A7BDB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey DIHMBOJAPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly GMHMEBHNAOE<TKey> CIEPDNOLKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly ALMLLDBPKBM IPEKLICENHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<HGELJMPBEBF> GNBDFBKLNPA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string GPIGNFOENKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x508B950", Offset = "0x508A750", VA = "0x18508B950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<HGELJMPBEBF> OHHIJKHDBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x508B980", Offset = "0x508A780", VA = "0x18508B980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public NBIAGJLHLIA FOPKKPAHPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x508B730", Offset = "0x508A530", VA = "0x18508B730")]
			[CompilerGenerated]
			get
			{
				return default(NBIAGJLHLIA);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x508B700", Offset = "0x508A500", VA = "0x18508B700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x508BB20", Offset = "0x508A920", VA = "0x18508BB20")]
		internal HGELJMPBEBF(GMHMEBHNAOE<TKey> CIEPDNOLKJK, TKey OPGJHIOADCK, ALMLLDBPKBM IPEKLICENHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x508B9C0", Offset = "0x508A7C0", VA = "0x18508B9C0")]
		public HGELJMPBEBF MAPPHAHPPMF(TKey OPGJHIOADCK, [Optional] ALMLLDBPKBM? DBKNCEPEJPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4489620", Offset = "0x4488420", VA = "0x184489620")]
		[AsyncStateMachine(typeof(KAMHHBIKNOJ<>))]
		public Task<T> EBNNJPMHGKA<T>(TKey OPGJHIOADCK, Func<HGELJMPBEBF, Task<T>> OHHICGADAKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x508B750", Offset = "0x508A550", VA = "0x18508B750", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class EEOHANPCDEL : IEnumerable<(TKey, List<TKey>, NBIAGJLHLIA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NBIAGJLHLIA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, NBIAGJLHLIA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public GMHMEBHNAOE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, NBIAGJLHLIA timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, NBIAGJLHLIA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E0F0", Offset = "0x2D5CEF0", VA = "0x182D5E0F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NBIAGJLHLIA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x4A441D0", Offset = "0x4A42FD0", VA = "0x184A441D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2D5E1E0", Offset = "0x2D5CFE0", VA = "0x182D5E1E0")]
		[DebuggerHidden]
		public EEOHANPCDEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4A44230", Offset = "0x4A43030", VA = "0x184A44230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4A43C00", Offset = "0x4A42A00", VA = "0x184A43C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4A44000", Offset = "0x4A42E00", VA = "0x184A44000")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4A44180", Offset = "0x4A42F80", VA = "0x184A44180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4A440C0", Offset = "0x4A42EC0", VA = "0x184A440C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NBIAGJLHLIA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x45D8CE0", Offset = "0x45D7AE0", VA = "0x1845D8CE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class BDDALAOMDBE : IEnumerable<(TKey, List<TKey>, NBIAGJLHLIA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NBIAGJLHLIA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, NBIAGJLHLIA timerEntry) <>2__current;

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
		private HGELJMPBEBF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public HGELJMPBEBF <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public GMHMEBHNAOE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<HGELJMPBEBF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, NBIAGJLHLIA timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, NBIAGJLHLIA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E0F0", Offset = "0x2D5CEF0", VA = "0x182D5E0F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NBIAGJLHLIA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6601630", Offset = "0x6600430", VA = "0x186601630", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2D5E1E0", Offset = "0x2D5CFE0", VA = "0x182D5E1E0")]
		[DebuggerHidden]
		public BDDALAOMDBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6601690", Offset = "0x6600490", VA = "0x186601690", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6600CF0", Offset = "0x65FFAF0", VA = "0x186600CF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x66014A0", Offset = "0x66002A0", VA = "0x1866014A0")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6600C90", Offset = "0x65FFA90", VA = "0x186600C90")]
		private void DFGOGGAACMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x66015E0", Offset = "0x66003E0", VA = "0x1866015E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6601500", Offset = "0x6600300", VA = "0x186601500", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NBIAGJLHLIA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5E47FD0", Offset = "0x5E46DD0", VA = "0x185E47FD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, NBIAGJLHLIA, ALMLLDBPKBM> AGJLPNGJFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, NBIAGJLHLIA, ALMLLDBPKBM> PEJNDHPALIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<GMHMEBHNAOE<TKey>, ALMLLDBPKBM> KHJOKDFJCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly HGELJMPBEBF IEOPKCLAGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool PJLPIIDDCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int OPPFNJIJHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch MMJNPOIDCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int DJOPAHCBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string BHEHFJJODCO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HGELJMPBEBF FFHNIGAFPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string GPIGNFOENKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5009E60", Offset = "0x5008C60", VA = "0x185009E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x500A020", Offset = "0x5008E20", VA = "0x18500A020")]
	public GMHMEBHNAOE(TKey OCDBLCFHIFD, ALMLLDBPKBM IPEKLICENHF, [Optional] int? MCINEAINKBA, [Optional][CanBeNull] Stopwatch MMJNPOIDCJG, [Optional] Action<TKey, NBIAGJLHLIA, ALMLLDBPKBM> AGJLPNGJFGN, [Optional] Action<TKey, NBIAGJLHLIA, ALMLLDBPKBM> PEJNDHPALIA, [Optional] Action<GMHMEBHNAOE<TKey>, ALMLLDBPKBM> KHJOKDFJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5009DD0", Offset = "0x5008BD0", VA = "0x185009DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5009EC0", Offset = "0x5008CC0", VA = "0x185009EC0")]
	[IteratorStateMachine(typeof(GMHMEBHNAOE<>.EEOHANPCDEL))]
	public IEnumerable<(TKey, List<TKey>, NBIAGJLHLIA)> LACLAMEMGKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5009F50", Offset = "0x5008D50", VA = "0x185009F50")]
	[IteratorStateMachine(typeof(GMHMEBHNAOE<>.BDDALAOMDBE))]
	private IEnumerable<(TKey, List<TKey>, NBIAGJLHLIA)> LACLAMEMGKK(List<TKey> GHADMHNDJBK, HGELJMPBEBF CFNBNFAEHIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5009D50", Offset = "0x5008B50", VA = "0x185009D50")]
	private (long, int) DHKAJDMFDAO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class HNHPPBPBBOF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut FIJDHCIEGJF(GMHMEBHNAOE<TKey> CIEPDNOLKJK);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected HNHPPBPBBOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class BBFHHGINCBN<TKey> : HNHPPBPBBOF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string OEBBGKGALKK(TKey OPGJHIOADCK);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x65FE840", Offset = "0x65FD640", VA = "0x1865FE840")]
	private static string FOPBHFEKAJF(TKey OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x65FE780", Offset = "0x65FD580", VA = "0x1865FE780", Slot = "4")]
	public override string FIJDHCIEGJF(GMHMEBHNAOE<TKey> CIEPDNOLKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x65FE630", Offset = "0x65FD430", VA = "0x1865FE630")]
	public string FIJDHCIEGJF(GMHMEBHNAOE<TKey> CIEPDNOLKJK, [NotNull] OEBBGKGALKK HKBDIAPKMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BGAAHEHPFKF(GMHMEBHNAOE<TKey> CIEPDNOLKJK, [NotNull] OEBBGKGALKK HKBDIAPKMEA);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4F07070", Offset = "0x4F05E70", VA = "0x184F07070")]
	protected BBFHHGINCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class MADFNJFPPPK<TKey> : HNHPPBPBBOF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string LFMCDLPLDHK(TKey OPGJHIOADCK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string LEHFONIELFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double EAOBOLOEMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool IEKEHDFNNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int JBBBGKMCGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> MEJJPKLIKNF;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x587B060", Offset = "0x5879E60", VA = "0x18587B060")]
	private static string FOPBHFEKAJF(TKey OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x587B440", Offset = "0x587A240", VA = "0x18587B440")]
	public MADFNJFPPPK(string LEHFONIELFJ = "F2", double EAOBOLOEMDA = double.MaxValue, bool IEKEHDFNNOB = false, int JBBBGKMCGPO = int.MaxValue, [Optional] ISet<string> MEJJPKLIKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x587A9B0", Offset = "0x58797B0", VA = "0x18587A9B0", Slot = "4")]
	public override Dictionary<string, string> FIJDHCIEGJF(GMHMEBHNAOE<TKey> CIEPDNOLKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x587A940", Offset = "0x5879740", VA = "0x18587A940")]
	private bool COFLLEOAKDM(string DDPOCHOCMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x587AA70", Offset = "0x5879870", VA = "0x18587AA70")]
	public Dictionary<string, string> FIJDHCIEGJF(GMHMEBHNAOE<TKey> CIEPDNOLKJK, LFMCDLPLDHK HKBDIAPKMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x587B0A0", Offset = "0x5879EA0", VA = "0x18587B0A0")]
	private string LGIHCLAAMBN(StringBuilder GAHIPALDHGF, List<TKey> LKKEPKLHEGH, LFMCDLPLDHK HKBDIAPKMEA, bool GOAIMLLOLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x587B2E0", Offset = "0x587A0E0", VA = "0x18587B2E0")]
	private static void NGODLGEMCAJ(StringBuilder JNJACGKGIAP, string EEGBINPKFKJ, bool LDDPEKCAFGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class DCIDPJMLBCH<TKey> : BBFHHGINCBN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct CCDOCBKGNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public OEBBGKGALKK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static DCIDPJMLBCH<TKey> MOIOIMEFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] BBPFAOKEHCP;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x452FB80", Offset = "0x452E980", VA = "0x18452FB80")]
	private DCIDPJMLBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x452EA80", Offset = "0x452D880", VA = "0x18452EA80", Slot = "5")]
	protected override string BGAAHEHPFKF(GMHMEBHNAOE<TKey> CIEPDNOLKJK, OEBBGKGALKK HKBDIAPKMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x452F950", Offset = "0x452E750", VA = "0x18452F950")]
	[CompilerGenerated]
	internal static string IKLONOPMMLO(string PNMPBPDNDAJ, TKey OPGJHIOADCK, CCDOCBKGNHN P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class DIFCNIKEIFP : GMHMEBHNAOE<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class MOOAKDLJPLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<DIFCNIKEIFP, ALMLLDBPKBM> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MOOAKDLJPLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8349360", Offset = "0x8348160", VA = "0x188349360")]
		internal void IOBEMOALENC(GMHMEBHNAOE<string> timer, ALMLLDBPKBM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8347F70", Offset = "0x8346D70", VA = "0x188347F70")]
	public DIFCNIKEIFP(ALMLLDBPKBM IPEKLICENHF, [Optional] string HJOJJGLGNFM, [Optional] int? MCINEAINKBA, [Optional] Stopwatch MMJNPOIDCJG, [Optional] Action<string, NBIAGJLHLIA, ALMLLDBPKBM> AGJLPNGJFGN, [Optional] Action<string, NBIAGJLHLIA, ALMLLDBPKBM> PEJNDHPALIA, [Optional] Action<DIFCNIKEIFP, ALMLLDBPKBM> KHJOKDFJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8347EB0", Offset = "0x8346CB0", VA = "0x188347EB0")]
	private static Action<GMHMEBHNAOE<string>, ALMLLDBPKBM> GCIKHPIAIJN(Action<DIFCNIKEIFP, ALMLLDBPKBM> LBJMJKFNAPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class JAMFJCPPDKK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class MOADMEAAEJP : JAMFJCPPDKK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static JAMFJCPPDKK MOIOIMEFPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8349220", Offset = "0x8348020", VA = "0x188349220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float ABPJADIJECB
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x13B96B0", Offset = "0x13B84B0", VA = "0x1813B96B0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8349310", Offset = "0x8348110", VA = "0x188349310")]
		public MOADMEAAEJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static JAMFJCPPDKK KOLNILONDCL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static JAMFJCPPDKK HANIMDCJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8348630", Offset = "0x8347430", VA = "0x188348630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float ABPJADIJECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected JAMFJCPPDKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JBJKHPALKPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HNDICJJKNNH<T> : JBJKHPALKPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> HEEBFPGMOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	AIKJELDGMEB<T> JMNJOBCDBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GCNDBENJMPD
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4730", Offset = "0x3CF3530", VA = "0x183CF4730")]
	public static HNDICJJKNNH<TResource> LDHIFJKCHDP<TResource, TId>(this IJBKKOGNFGH<TId, TResource> FAJIBAIPGCN, TId FMFDAFLDAAK, [Optional] Func<TId, CancellationToken, Task<TResource>>? KIBBCONFMFD) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class EHIALDAKODG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class IBIIOOJFHHL<T> : PLOEJGCOECH<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> HEEBFPGMOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override AIKJELDGMEB<T?> JMNJOBCDBLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5207C30", Offset = "0x5206A30", VA = "0x185207C30")]
		public IBIIOOJFHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
		protected override void ICOIHHDPGHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class FLNHKBGBDPE<T> : PLOEJGCOECH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T DEEDJFLGJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? DBCEACOLHKH;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> HEEBFPGMOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override AIKJELDGMEB<T> JMNJOBCDBLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4F2A910", Offset = "0x4F29710", VA = "0x184F2A910")]
		public FLNHKBGBDPE(T KJDCMLLLKLE, Action<T>? GAOPJHAPCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4F2A8C0", Offset = "0x4F296C0", VA = "0x184F2A8C0", Slot = "10")]
		protected override void ICOIHHDPGHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class AECACDNLDDE<T> : PLOEJGCOECH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> HEEBFPGMOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override AIKJELDGMEB<T> JMNJOBCDBLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5197AD0", Offset = "0x51968D0", VA = "0x185197AD0")]
		public AECACDNLDDE(Exception DNLEOFNAGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
		protected override void ICOIHHDPGHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class HCBJCLBKBKA<T> : PLOEJGCOECH<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct LBHKIGNNKBP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<HNDICJJKNNH<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<HNDICJJKNNH<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5675140", Offset = "0x5673F40", VA = "0x185675140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x5675B40", Offset = "0x5674940", VA = "0x185675B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct NCAPEGEHIPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<HNDICJJKNNH<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<HNDICJJKNNH<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x5964390", Offset = "0x5963190", VA = "0x185964390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5964620", Offset = "0x5963420", VA = "0x185964620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<HNDICJJKNNH<T>> IGLEPPLBILP;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> HEEBFPGMOHA
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override AIKJELDGMEB<T> JMNJOBCDBLH
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x507C350", Offset = "0x507B150", VA = "0x18507C350")]
		public HCBJCLBKBKA(Task<HNDICJJKNNH<T>> MGEGHBBNKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x507BF70", Offset = "0x507AD70", VA = "0x18507BF70", Slot = "10")]
		protected override void ICOIHHDPGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x507C1F0", Offset = "0x507AFF0", VA = "0x18507C1F0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(HCBJCLBKBKA<>.LBHKIGNNKBP))]
		internal static Task<T> JPPOPHJFCML(Task<HNDICJJKNNH<T>> MGEGHBBNKMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x507BE80", Offset = "0x507AC80", VA = "0x18507BE80")]
		[AsyncStateMachine(typeof(HCBJCLBKBKA<>.NCAPEGEHIPM))]
		[CompilerGenerated]
		internal static Task DFKLBKKKICC(Task<HNDICJJKNNH<T>> MGEGHBBNKMN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class FCBKNICALEO<TIn, TOut> : PLOEJGCOECH<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct KDBHBAIJEOF : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x55C4CF0", Offset = "0x55C3AF0", VA = "0x1855C4CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4574F00", Offset = "0x4573D00", VA = "0x184574F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly HNDICJJKNNH<TIn> OFANIEBJPEG;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> HEEBFPGMOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override AIKJELDGMEB<TOut> JMNJOBCDBLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4EF82E0", Offset = "0x4EF70E0", VA = "0x184EF82E0")]
		public FCBKNICALEO(HNDICJJKNNH<TIn> NPANNMGCDKC, Func<TIn, TOut> ONHIJHBBEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8290", Offset = "0x4EF7090", VA = "0x184EF8290", Slot = "10")]
		protected override void ICOIHHDPGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF80C0", Offset = "0x4EF6EC0", VA = "0x184EF80C0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(FCBKNICALEO<, >.KDBHBAIJEOF))]
		internal static Task<TOut> HOGLPMLMAGC(Task<TIn> OMDBMHNFEAH, Func<TIn, TOut> ONHIJHBBEIE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F3B0", Offset = "0x3B7E1B0", VA = "0x183B7F3B0")]
	public static HNDICJJKNNH<T> FBGBKFBLNFL<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F410", Offset = "0x3B7E210", VA = "0x183B7F410")]
	public static HNDICJJKNNH<T> MHKHPCCGIJE<T>(T MOBFLOHJOKJ, [Optional] Action<T>? GAOPJHAPCMF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5C50", Offset = "0x3AA4A50", VA = "0x183AA5C50")]
	public static HNDICJJKNNH<T> HFGOPNMIADP<T>(Exception DNLEOFNAGNA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5C50", Offset = "0x3AA4A50", VA = "0x183AA5C50")]
	public static HNDICJJKNNH<T> BAJGKNAGFNO<T>(Task<HNDICJJKNNH<T>> MGEGHBBNKMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3B53E10", Offset = "0x3B52C10", VA = "0x183B53E10")]
	public static HNDICJJKNNH<TOut> DGABKBJAOAH<TOut, TIn>(HNDICJJKNNH<TIn> MJIBDELKIML, Func<TIn, TOut> ONHIJHBBEIE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class PLOEJGCOECH<T> : HNDICJJKNNH<T>, JBJKHPALKPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string PCBPJJCIOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly KNMKMPHCMCP FHDJHLHGNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool PJLPIIDDCCN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC30", Offset = "0xB7AA30", VA = "0x180B7BC30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> HEEBFPGMOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract AIKJELDGMEB<T> JMNJOBCDBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A640", Offset = "0x5C09440", VA = "0x185C0A640")]
	public PLOEJGCOECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A380", Offset = "0x5C09180", VA = "0x185C0A380", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void ICOIHHDPGHM();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class FNDHNLNJILN<TTask, T> : PLOEJGCOECH<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class KIHMAKOKKLK
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
			public KIHMAKOKKLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x44FE9A0", Offset = "0x44FD7A0", VA = "0x1844FE9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x44FEC70", Offset = "0x44FDA70", VA = "0x1844FEC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public FNDHNLNJILN<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KIHMAKOKKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x55E7120", Offset = "0x55E5F20", VA = "0x1855E7120")]
		[AsyncStateMachine(typeof(FNDHNLNJILN<, >.KIHMAKOKKLK.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> OKGOHHKHFDF(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> MGEGHBBNKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource DPCAFKKKHOA;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> HEEBFPGMOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override AIKJELDGMEB<T> JMNJOBCDBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4F312F0", Offset = "0x4F300F0", VA = "0x184F312F0")]
	protected FNDHNLNJILN(TTask MGEGHBBNKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4F312A0", Offset = "0x4F300A0", VA = "0x184F312A0", Slot = "10")]
	protected override void ICOIHHDPGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T EKONMNNOOFN(TTask MIIAOOKGJGO);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void EEMDJEPOHOI();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LIHIHBBBDIM<T> : PLOEJGCOECH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly JAFFBBCIDNI<Task<T>> EGGABLOPIOJ;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> HEEBFPGMOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x55DBF90", Offset = "0x55DAD90", VA = "0x1855DBF90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override AIKJELDGMEB<T> JMNJOBCDBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x568E910", Offset = "0x568D710", VA = "0x18568E910")]
	public LIHIHBBBDIM(JAFFBBCIDNI<Task<T>> EPLKAJBFBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x568E8F0", Offset = "0x568D6F0", VA = "0x18568E8F0", Slot = "10")]
	protected override void ICOIHHDPGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JCJIONNHOII
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName GNGBNMNHHMN;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> CGBBOIKFAEJ;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8348790", Offset = "0x8347590", VA = "0x188348790")]
	public static int BGBBLKNFMDE(this KGHOEDFHBHK COEPJCAHBGP, IncrementalHash HOHPDECNKDA, byte[] DPCHKHHPHFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8348820", Offset = "0x8347620", VA = "0x188348820")]
	public static bool KHPFFEKDHII([CanBeNull] this KGHOEDFHBHK COEPJCAHBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8348880", Offset = "0x8347680", VA = "0x188348880")]
	public static bool KHPFFEKDHII([CanBeNull] this KGHOEDFHBHK COEPJCAHBGP, [Out] string DFOJBJDIKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8348B90", Offset = "0x8347990", VA = "0x188348B90")]
	public static bool KHPFFEKDHII([CanBeNull] this KGHOEDFHBHK COEPJCAHBGP, IncrementalHash HOHPDECNKDA, byte[] DPCHKHHPHFN, [Out] string DFOJBJDIKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8348ED0", Offset = "0x8347CD0", VA = "0x188348ED0")]
	private static bool LMONBGGOPAK(byte[] JLNLAHFAPNP, Span<byte> ACFDKHAMPCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class GHHDBPPHDDJ
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8348290", Offset = "0x8347090", VA = "0x188348290")]
	public static int JGDKMGLHNBG(HashAlgorithmName HHOPJHELAHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7A90", Offset = "0x3CF6890", VA = "0x183CF7A90")]
	public static int BGBBLKNFMDE<T>(this T DFNIKLHAFHI, byte[] BFHDPJEEBJE, IncrementalHash HOHPDECNKDA, byte[] HAABPKKBMCD) where T : IDNIAHPHMNP
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface IDNIAHPHMNP
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HOHPDECNKDA);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KGHOEDFHBHK : IDNIAHPHMNP
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] GMHHBFEFFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] LPOOHBEFJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class AKNHAIMKKEL
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool HNAHDIONPJJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> EBCEFLHADEK;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> PELNPLKNEOM;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding JMCKCCOOJLL;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> CHFAIHLNCJA;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3254620", Offset = "0x3253420", VA = "0x183254620")]
	public static void FFDHNLIBPGP<T>(this IncrementalHash GJKGPFAOKPD, [CanBeNull] T PGJHFGMMOON) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3254C00", Offset = "0x3253A00", VA = "0x183254C00")]
	public static void JGOMAPPGABI<T>(this IncrementalHash GJKGPFAOKPD, [CanBeNull] T DFNIKLHAFHI) where T : IDNIAHPHMNP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x32546E0", Offset = "0x32534E0", VA = "0x1832546E0")]
	public static void HBNPIJPKPOM<T>(this IncrementalHash GJKGPFAOKPD, [CanBeNull] IList<T> IPHJMEHGKAC) where T : IDNIAHPHMNP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8346CE0", Offset = "0x8345AE0", VA = "0x188346CE0")]
	private static bool BAANJFKGODL([CanBeNull] IDNIAHPHMNP DFNIKLHAFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8347640", Offset = "0x8346440", VA = "0x188347640")]
	public static void PKPENFOEGGJ(this IncrementalHash HOHPDECNKDA, string? NBONBDLPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8346D70", Offset = "0x8345B70", VA = "0x188346D70")]
	public static void BIPPOLHELNH(this IncrementalHash HOHPDECNKDA, long GILHFMHIMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8346B10", Offset = "0x8345910", VA = "0x188346B10")]
	public static void AKAPMEMACLI(this IncrementalHash HOHPDECNKDA, int FHBAMHHJIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x83472A0", Offset = "0x83460A0", VA = "0x1883472A0")]
	public static void GDLEBAMMDAB(this IncrementalHash HOHPDECNKDA, short DLCPDFHIEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8347470", Offset = "0x8346270", VA = "0x188347470")]
	public static void LIIAABHMLEC(this IncrementalHash HOHPDECNKDA, byte ILFCHDOBNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8347130", Offset = "0x8345F30", VA = "0x188347130")]
	public static void FHIAHDOHAGA(this IncrementalHash HOHPDECNKDA, bool IKGBIBMOLON, bool MEFDJAEIPJB = false, bool NGMNHBDADMN = false, bool EMPCHBDIEAL = false, bool IOHIICMBKHM = false, bool GIPJAIALBCL = false, bool MMABJGAKMMA = false, bool EMMFLDCCALM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3254C90", Offset = "0x3253A90", VA = "0x183254C90")]
	public static void NGMEIEMKDNO<T>(this IncrementalHash HOHPDECNKDA, T AGNBPCKNDIK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8346F40", Offset = "0x8345D40", VA = "0x188346F40")]
	public static void BPLDAGMBPPN(this IncrementalHash HOHPDECNKDA, float EMNAPDEPGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8347580", Offset = "0x8346380", VA = "0x188347580")]
	public static void NBNGJIBDBAI(this IncrementalHash HOHPDECNKDA, ulong GHAKJFHOJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x83475E0", Offset = "0x83463E0", VA = "0x1883475E0")]
	public static void OHFEDCNBLNF(this IncrementalHash HOHPDECNKDA, uint GIFHLLIDNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x83470D0", Offset = "0x8345ED0", VA = "0x1883470D0")]
	public static void DFCCOIHDHAP(this IncrementalHash HOHPDECNKDA, ushort PCJAKEPPMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8346FA0", Offset = "0x8345DA0", VA = "0x188346FA0")]
	public static void CLHKCAECJGK(this IncrementalHash HOHPDECNKDA, Vector3 PGKIHABHGOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DMIHNBDOENL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x83480C0", Offset = "0x8346EC0", VA = "0x1883480C0")]
	public DMIHNBDOENL(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class KNMGDNAIBNL
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void BHFFDGMLFDH(ushort GGCGBNHDFLE, ushort BBPMJJHECJD, ushort HBEEGMKKHCC, ushort MNMAMEPBMBB);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void FCBHCKFAALA(ushort EOLOJFJPIFM, ushort GCDDLAGPJBP);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void PAPAGPIIGPO();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort LBCDJAEANPA = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected KNMGDNAIBNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class FEDJJDFEGFO<T> : KNMGDNAIBNL where T : FEDJJDFEGFO<T>.MDOEGIJGONP
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface MDOEGIJGONP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		FCBHCKFAALA LDPCIINLFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		FCBHCKFAALA NOPHDNBJGDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		PAPAGPIIGPO PFPJGPKEHEB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> LBPEHOICPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PAPAGPIIGPO MNAICLALCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private PAPAGPIIGPO LMOKGGDHHFH;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool MFEANJFCIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort EDIMLEEGNFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x12761B0", Offset = "0x1274FB0", VA = "0x1812761B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x12764B0", Offset = "0x12752B0", VA = "0x1812764B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort GMJMHMKIELI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4F00E50", Offset = "0x4EFFC50", VA = "0x184F00E50")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F00CB0", Offset = "0x4EFFAB0", VA = "0x184F00CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort PDOOABALJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xF589A0", Offset = "0xF577A0", VA = "0x180F589A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xF58A60", Offset = "0xF57860", VA = "0x180F58A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort INLJAIBJNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4F01100", Offset = "0x4EFFF00", VA = "0x184F01100")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4F00CC0", Offset = "0x4EFFAC0", VA = "0x184F00CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool JAAMHIKKACH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1276120", Offset = "0x1274F20", VA = "0x181276120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool BHANFKMLLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x22DFEA0", Offset = "0x22DECA0", VA = "0x1822DFEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event BHFFDGMLFDH PGFHGAPPJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4F01110", Offset = "0x4EFFF10", VA = "0x184F01110")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4F00DB0", Offset = "0x4EFFBB0", VA = "0x184F00DB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4F002F0", Offset = "0x4EFF0F0", VA = "0x184F002F0")]
	private T AIMEPPODBDC(ushort ENKEFHKBJDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4F00CD0", Offset = "0x4EFFAD0", VA = "0x184F00CD0")]
	private T GAKKOHFPDAC(ushort ENKEFHKBJDM, ushort CBHPLHGMDDG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4F00D60", Offset = "0x4EFFB60", VA = "0x184F00D60")]
	protected T GMOPBJCBOHM(uint NNPMAKEDIDE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4F011C0", Offset = "0x4EFFFC0", VA = "0x184F011C0")]
	protected FEDJJDFEGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F00C90", Offset = "0x4EFFA90", VA = "0x184F00C90")]
	public void BLKKHMNBNAG(ushort DBPHIEALIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4F00B70", Offset = "0x4EFF970", VA = "0x184F00B70")]
	public void BLKKHMNBNAG(ushort DBPHIEALIOE, ushort BFDEDANEDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4F00BC0", Offset = "0x4EFF9C0", VA = "0x184F00BC0", Slot = "4")]
	protected virtual void BLKKHMNBNAG(uint AJLOEIACMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4F00380", Offset = "0x4EFF180", VA = "0x184F00380")]
	protected void ALIBAMJMCPA(uint AJLOEIACMEO, uint DNFJIADIJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4F00B00", Offset = "0x4EFF900", VA = "0x184F00B00")]
	protected void BKPFJLAMJNL(ushort ENKEFHKBJDM, ushort CBHPLHGMDDG, T GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F010B0", Offset = "0x4EFFEB0", VA = "0x184F010B0")]
	private void IOKCMCDJADI(uint NNPMAKEDIDE, T GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F00E60", Offset = "0x4EFFC60", VA = "0x184F00E60")]
	protected void IMFLECAIDDE(float GCGEIJPOBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F011B0", Offset = "0x4EFFFB0", VA = "0x184F011B0")]
	protected uint NKJLMIDIEOH(ushort ENKEFHKBJDM, ushort CBHPLHGMDDG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F010E0", Offset = "0x4EFFEE0", VA = "0x184F010E0")]
	protected ushort JLHCKFNHOAF(uint NNDNLKAADJF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F010F0", Offset = "0x4EFFEF0", VA = "0x184F010F0")]
	protected ushort KMCJMNDGHII(uint NNDNLKAADJF)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class ICENMMIIEFF : FEDJJDFEGFO<ICENMMIIEFF.HEJGJGFEMFH>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class HEJGJGFEMFH : MDOEGIJGONP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public FCBHCKFAALA LDPCIINLFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public FCBHCKFAALA NOPHDNBJGDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public PAPAGPIIGPO PFPJGPKEHEB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HEJGJGFEMFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8348430", Offset = "0x8347230", VA = "0x188348430")]
	public void FMOKAOIDLCM(ushort PELJBLBDCPE, FCBHCKFAALA FOOIAKOANPE, FCBHCKFAALA ADLPGKJGLOK, PAPAGPIIGPO JCNCFEOINAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8348510", Offset = "0x8347310", VA = "0x188348510")]
	public void FMOKAOIDLCM(ushort ENKEFHKBJDM, ushort CBHPLHGMDDG, FCBHCKFAALA FOOIAKOANPE, FCBHCKFAALA ADLPGKJGLOK, PAPAGPIIGPO JCNCFEOINAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x83483E0", Offset = "0x83471E0", VA = "0x1883483E0")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x83485F0", Offset = "0x83473F0", VA = "0x1883485F0")]
	protected ICENMMIIEFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LOMOMHCANIN : ICENMMIIEFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool INELPJMLLHN;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD913C0", Offset = "0xD901C0", VA = "0x180D913C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xE7F1E0", Offset = "0xE7DFE0", VA = "0x180E7F1E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x83491C0", Offset = "0x8347FC0", VA = "0x1883491C0")]
	public void IEHCJBEIMLK(ushort PIKCPONDOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8349160", Offset = "0x8347F60", VA = "0x188349160")]
	public void IEHCJBEIMLK(ushort PIKCPONDOPI, ushort BEMAJJFNBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x83485F0", Offset = "0x83473F0", VA = "0x1883485F0")]
	public LOMOMHCANIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class JJOCCEJDHMA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class FPJBFHCIEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode DBBEADIHLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode PJGOIMBEKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HAPLCHAACAB KINIEEOGPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<HAPLCHAACAB> DBENMCKGCMN;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FPJBFHCIEGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct HAPLCHAACAB : IComparable<HAPLCHAACAB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int JFELCJGHJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant PDJAOGMHKAK;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1942DD0", Offset = "0x1941BD0", VA = "0x181942DD0")]
		public HAPLCHAACAB(int JFELCJGHJPG, TClaimant PDJAOGMHKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5048850", Offset = "0x5047650", VA = "0x185048850")]
		public bool OHOKBNLEODL([In] HAPLCHAACAB FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5048840", Offset = "0x5047640", VA = "0x185048840")]
		public bool MCAGKHOIJOJ([In] HAPLCHAACAB FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5048830", Offset = "0x5047630", VA = "0x185048830", Slot = "4")]
		public int CompareTo(HAPLCHAACAB FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x50488B0", Offset = "0x50476B0", VA = "0x1850488B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum FLKDFKGCNPK
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class MJAMGIDMCOI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public JJOCCEJDHMA<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public MJAMGIDMCOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x58B9CD0", Offset = "0x58B8AD0", VA = "0x1858B9CD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x58B9E90", Offset = "0x58B8C90", VA = "0x1858B9E90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x58B9DB0", Offset = "0x58B8BB0", VA = "0x1858B9DB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4F000C0", Offset = "0x4EFEEC0", VA = "0x184F000C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly FIPFPHMIMGE<FPJBFHCIEGI> KHBDPOCBEIB;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly FIPFPHMIMGE<List<HAPLCHAACAB>> HPCMJOHEGIM;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int MODNKLDFCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> GDLKLCELMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, FPJBFHCIEGI> AHNCLBKMKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private FLKDFKGCNPK KJLMJGOOKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EDCKDJLGGGP(TNode DFHOHFFNCIJ);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NPOLIIHOLIJ(TNode DFHOHFFNCIJ, TClaimant GGMGPIPBNND, TClaimant FEKNKDEFGLP);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x54B3890", Offset = "0x54B2690", VA = "0x1854B3890")]
	public JJOCCEJDHMA(FLKDFKGCNPK KJLMJGOOKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x54B2A90", Offset = "0x54B1890", VA = "0x1854B2A90")]
	public void EGBEKDOGIMP(TNode DFHOHFFNCIJ, TNode HNDFKDHDHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x54B2FD0", Offset = "0x54B1DD0", VA = "0x1854B2FD0")]
	public void MBDBMLKGPGF(TClaimant PDJAOGMHKAK, TNode PPODKIMADFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x54B28D0", Offset = "0x54B16D0", VA = "0x1854B28D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x54B3540", Offset = "0x54B2340", VA = "0x1854B3540")]
	private void OENDFHDFCDI(TClaimant PDJAOGMHKAK, TNode PCAMMLFDAIB, TNode PPODKIMADFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x54B2780", Offset = "0x54B1580", VA = "0x1854B2780")]
	private int DLDIJHBEPIH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x54B2B20", Offset = "0x54B1920", VA = "0x1854B2B20")]
	private void JOPGDIPLPJD(TClaimant PDJAOGMHKAK, TNode BGIAPFFEHDP, TNode FNOFFMCCBDL, int OGOCHFFHGNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x54B26F0", Offset = "0x54B14F0", VA = "0x1854B26F0")]
	private void CNFJKGIJHJK(HAPLCHAACAB JIFKAEJNGOK, FPJBFHCIEGI ILCELEMMMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x54B2060", Offset = "0x54B0E60", VA = "0x1854B2060")]
	private void AEGIMKCIGPL(TClaimant PDJAOGMHKAK, TNode BGIAPFFEHDP, TNode FNOFFMCCBDL, int OGOCHFFHGNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x54B25E0", Offset = "0x54B13E0", VA = "0x1854B25E0")]
	private void CFKNKPHFLDD(HAPLCHAACAB JIFKAEJNGOK, TNode DFHOHFFNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x54B30F0", Offset = "0x54B1EF0", VA = "0x1854B30F0")]
	private void MBHGBNEDJEP(HAPLCHAACAB JIFKAEJNGOK, FPJBFHCIEGI ILCELEMMMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x54B2340", Offset = "0x54B1140", VA = "0x1854B2340")]
	private void AOFBAAMIMMG(FPJBFHCIEGI ILCELEMMMGJ, bool NFCKLFBOFPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x54B31E0", Offset = "0x54B1FE0", VA = "0x1854B31E0")]
	private void MOGDHPJJCLF(FPJBFHCIEGI ILCELEMMMGJ, TNode HNDFKDHDHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x54B27F0", Offset = "0x54B15F0", VA = "0x1854B27F0")]
	[IteratorStateMachine(typeof(JJOCCEJDHMA<, >.MJAMGIDMCOI))]
	private IEnumerable<TNode> DLIAELOMGAJ(TNode BGIAPFFEHDP, TNode FNOFFMCCBDL, bool KBGLJJCFBHF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x54B35E0", Offset = "0x54B23E0", VA = "0x1854B35E0")]
	private FPJBFHCIEGI OHIABNGINOB(TNode DFHOHFFNCIJ, TNode PJGOIMBEKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x54B2E60", Offset = "0x54B1C60", VA = "0x1854B2E60")]
	private FPJBFHCIEGI MALLFINPKCH(TNode DFHOHFFNCIJ, TNode PJGOIMBEKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x54B2470", Offset = "0x54B1270", VA = "0x1854B2470")]
	private void BIKDHJCOKFJ(FPJBFHCIEGI ILCELEMMMGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class EOCLFJJIBDB<T> : IEnumerable<EOCLFJJIBDB<T>.NDIFJHHBJMD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct NDIFJHHBJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T HGMAIPELJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int JJJJBEGKNIN;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class DOKJIPKBIJM : IEnumerator<NDIFJHHBJMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private EOCLFJJIBDB<T> OKBODOGBGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int JJJJBEGKNIN;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x45B4C10", Offset = "0x45B3A10", VA = "0x1845B4C10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public NDIFJHHBJMD BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x45B4D40", Offset = "0x45B3B40", VA = "0x1845B4D40", Slot = "4")]
			get
			{
				return default(NDIFJHHBJMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x45B4D00", Offset = "0x45B3B00", VA = "0x1845B4D00")]
		public DOKJIPKBIJM(EOCLFJJIBDB<T> OKBODOGBGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x45B4B80", Offset = "0x45B3980", VA = "0x1845B4B80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x45B4C00", Offset = "0x45B3A00", VA = "0x1845B4C00", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x130AE30", Offset = "0x1309C30", VA = "0x18130AE30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct PJFCIEGOACL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool NCFDMLDMHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T HGMAIPELJHM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int BBCLODNMCJA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> DHKHNPEENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private PJFCIEGOACL[] OOJDJEDIKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int MHJLKCDAFEG;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int GLIJNOFKAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4516A90", Offset = "0x4515890", VA = "0x184516A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A530", Offset = "0x4A79330", VA = "0x184A7A530")]
	public EOCLFJJIBDB(int FIBLEJKLMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A610", Offset = "0x4A79410", VA = "0x184A7A610")]
	public EOCLFJJIBDB(NDIFJHHBJMD[] FHLHNMNDEMD, bool GGDJNANIAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A1C0", Offset = "0x4A78FC0", VA = "0x184A7A1C0")]
	public int IHIPBBCECPD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4A79CE0", Offset = "0x4A78AE0", VA = "0x184A79CE0")]
	private int APCHGOJADMN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A340", Offset = "0x4A79140", VA = "0x184A7A340", Slot = "6")]
	protected virtual uint MAFILIMEBOO(uint HOHPDECNKDA, T HGMAIPELJHM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A410", Offset = "0x4A79210", VA = "0x184A7A410")]
	public bool OIHJPAHBJDE(T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A0F0", Offset = "0x4A78EF0", VA = "0x184A7A0F0")]
	public int APLNMIJLNML(T HGMAIPELJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A250", Offset = "0x4A79050", VA = "0x184A7A250")]
	public T LHIIIPAFAOC(int JJJJBEGKNIN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4A79A80", Offset = "0x4A78880", VA = "0x184A79A80")]
	public bool AKPHBPJOEJB(T HGMAIPELJHM, bool AIPDBDFCPDJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4A79AD0", Offset = "0x4A788D0", VA = "0x184A79AD0")]
	public bool AKPHBPJOEJB(T HGMAIPELJHM, int JJJJBEGKNIN, bool AIPDBDFCPDJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A370", Offset = "0x4A79170", VA = "0x184A7A370")]
	private int OIFKMGJLBHM(int DOCKBMMINED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A4B0", Offset = "0x4A792B0", VA = "0x184A7A4B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A4B0", Offset = "0x4A792B0", VA = "0x184A7A4B0", Slot = "4")]
	private IEnumerator<NDIFJHHBJMD> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class FIPFPHMIMGE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> NMIHGIEBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> JKOGDEAJEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int ELCGFEPHFMF;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4F12D10", Offset = "0x4F11B10", VA = "0x184F12D10")]
	public static FIPFPHMIMGE<T> LAFLFGAJBLN(int FIBLEJKLMBM = 0, int ELCGFEPHFMF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4F12C30", Offset = "0x4F11A30", VA = "0x184F12C30")]
	public static FIPFPHMIMGE<T> KPNCOMPOJEB(int FIBLEJKLMBM = 0, int ELCGFEPHFMF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4F12ED0", Offset = "0x4F11CD0", VA = "0x184F12ED0")]
	public FIPFPHMIMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4F12F00", Offset = "0x4F11D00", VA = "0x184F12F00")]
	public FIPFPHMIMGE(int FIBLEJKLMBM, int ELCGFEPHFMF = int.MaxValue, bool IDKGKIGLMNM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4F12A90", Offset = "0x4F11890", VA = "0x184F12A90")]
	public T HIGNFNKNAEG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4F12DF0", Offset = "0x4F11BF0", VA = "0x184F12DF0")]
	public void OJNCHOHBCNI(T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4F129B0", Offset = "0x4F117B0", VA = "0x184F129B0")]
	private void FIMJMHKEDMO(T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4F12840", Offset = "0x4F11640", VA = "0x184F12840")]
	private void DNOMMGNIGAN(T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4F12860", Offset = "0x4F11660", VA = "0x184F12860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4F12640", Offset = "0x4F11440", VA = "0x184F12640")]
	private void ALFIJKLLBMG(IEnumerable<T> OOFDDMCKJPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class POKFAMIPLBK<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> IMNNEOMDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T COHBNLLKOBJ;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T PLHLEFEBMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5C1AE90", Offset = "0x5C19C90", VA = "0x185C1AE90")]
	public bool ACMJDELJLOF(T HGMAIPELJHM, int JFELCJGHJPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4F36080", Offset = "0x4F34E80", VA = "0x184F36080")]
	public bool KMCKMJIAHCE(int JFELCJGHJPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5C1B170", Offset = "0x5C19F70", VA = "0x185C1B170")]
	public T INKHDKAECEK(int FCPEIMBAMEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5C1B370", Offset = "0x5C1A170", VA = "0x185C1B370")]
	private bool MBNHHGNAIOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5C1AF10", Offset = "0x5C19D10", VA = "0x185C1AF10")]
	public bool CFOKPIKBEGL(int JFELCJGHJPG, [Out] T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5472E50", Offset = "0x5471C50", VA = "0x185472E50")]
	public POKFAMIPLBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class JGGGCFDKAGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct CKAKKHKHNFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T DDHBFJGPDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int MNAEAPLJABJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<CKAKKHKHNFN> EIJDIHIGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T PFDKLBHJDNA;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4516A90", Offset = "0x4515890", VA = "0x184516A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5465680", Offset = "0x5464480", VA = "0x185465680")]
	public bool DHFLKPINICF(T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5465B00", Offset = "0x5464900", VA = "0x185465B00")]
	public void DPHJBDIDPOG(T HGMAIPELJHM, int JFELCJGHJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5466040", Offset = "0x5464E40", VA = "0x185466040")]
	public bool MDNHCHGJFLC(T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5465B80", Offset = "0x5464980", VA = "0x185465B80")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5466280", Offset = "0x5465080", VA = "0x185466280")]
	public T MPDICBFNOHL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5465D60", Offset = "0x5464B60", VA = "0x185465D60")]
	protected void ICEOBPGFDBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5466320", Offset = "0x5465120", VA = "0x185466320")]
	public JGGGCFDKAGF()
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
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x8349A30", Offset = "0x8348830", VA = "0x188349A30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8349D00", Offset = "0x8348B00", VA = "0x188349D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8349C10", Offset = "0x8348A10", VA = "0x188349C10")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x8349980", Offset = "0x8348780", VA = "0x188349980")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x8349C50", Offset = "0x8348A50", VA = "0x188349C50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x8349B60", Offset = "0x8348960", VA = "0x188349B60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8349900", Offset = "0x8348700", VA = "0x188349900")]
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

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8780", Offset = "0x5DF7580", VA = "0x185DF8780", Slot = "4")]
		public virtual T LACGEHFPBHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface CPKHOBLJBGD
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache EIFPOBLHHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct DGOFOCHONPD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> NGGCNGNMEBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool KKGGELGINKB;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1AA7590", Offset = "0x1AA6390", VA = "0x181AA7590")]
			public DGOFOCHONPD(List<Component> NGGCNGNMEBF, bool KKGGELGINKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x4540190", Offset = "0x453EF90", VA = "0x184540190")]
			public MJODOFLKFKB<T> OLGNAIIDMLF()
			{
				return default(MJODOFLKFKB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x4540200", Offset = "0x453F000", VA = "0x184540200", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x4540200", Offset = "0x453F000", VA = "0x184540200", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct MJODOFLKFKB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> NGGCNGNMEBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool KKGGELGINKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int JJJJBEGKNIN;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T BONNGALDEBJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x58BCF20", Offset = "0x58BBD20", VA = "0x1858BCF20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x58BCEB0", Offset = "0x58BBCB0", VA = "0x1858BCEB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x58BCEF0", Offset = "0x58BBCF0", VA = "0x1858BCEF0")]
			public MJODOFLKFKB(List<Component> NGGCNGNMEBF, bool KKGGELGINKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x58BCDF0", Offset = "0x58BBBF0", VA = "0x1858BCDF0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x58BCE00", Offset = "0x58BBC00", VA = "0x1858BCE00", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x4ADBF10", Offset = "0x4ADAD10", VA = "0x184ADBF10", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x834B720", Offset = "0x834A520", VA = "0x18834B720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x834B190", Offset = "0x8349F90", VA = "0x18834B190")]
		private void IEHCJBEIMLK(GameObject OADMNNJGFJI, bool PPPGPLMAHNI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x834B100", Offset = "0x8349F00", VA = "0x18834B100")]
		public static void IEHCJBEIMLK(GameObject OADMNNJGFJI, ToolHierarchyCache FAJIBAIPGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x834B300", Offset = "0x834A100", VA = "0x18834B300")]
		public void NGLAMLCJDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x40AFEB0", Offset = "0x40AECB0", VA = "0x1840AFEB0")]
		public void JEBCOFBBJGE<T>(Action<T> IJBAPONMLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x40B00D0", Offset = "0x40AEED0", VA = "0x1840B00D0")]
		public T JNAPIKJPHHP<T>(bool KKGGELGINKB = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x40AFDF0", Offset = "0x40AEBF0", VA = "0x1840AFDF0")]
		public DGOFOCHONPD<T> BIPKPEBAAHA<T>(bool KKGGELGINKB = false) where T : class
		{
			return default(DGOFOCHONPD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x834B310", Offset = "0x834A110", VA = "0x18834B310")]
		public List<Component> OJJDHPNDJEF(Type ADGMECOLKNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x834B010", Offset = "0x8349E10", VA = "0x18834B010", Slot = "4")]
		public bool Equals(ToolHierarchyCache DBBMOEGPNPP, ToolHierarchyCache COFKGIHGCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x834B090", Offset = "0x8349E90", VA = "0x18834B090", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ALGAKMGCCLO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class KHIHLGAIILD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int FIBLEJKLMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int ECJPGIEGDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> HHGHCHEOFCJ;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x55DBF90", Offset = "0x55DAD90", VA = "0x1855DBF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T PNHGDBJBEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x55DC340", Offset = "0x55DB140", VA = "0x1855DC340")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T GILHBHGCOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x55DC1A0", Offset = "0x55DAFA0", VA = "0x1855DC1A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T POIMFGKEDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x55DBFD0", Offset = "0x55DADD0", VA = "0x1855DBFD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x55DC420", Offset = "0x55DB220", VA = "0x1855DC420")]
	public KHIHLGAIILD(int FIBLEJKLMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x55DBD60", Offset = "0x55DAB60", VA = "0x1855DBD60")]
	public void DPHJBDIDPOG(T JNOCFPFLNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x55DBF50", Offset = "0x55DAD50", VA = "0x1855DBF50")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x55DBE80", Offset = "0x55DAC80", VA = "0x1855DBE80")]
	public void FMBLHICIJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x55DC230", Offset = "0x55DB030", VA = "0x1855DC230")]
	public void LAGGOLMLMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x55DBE70", Offset = "0x55DAC70", VA = "0x1855DBE70")]
	public void EAENLFGJLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x55DC0C0", Offset = "0x55DAEC0", VA = "0x1855DC0C0")]
	public List<T> HODKNKMECEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class INGLKBMOAOH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct ALJFLLGABGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int MNAEAPLJABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T DDHBFJGPDAJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, ALJFLLGABGB> IMNNEOMDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> JGFBOIDNCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T COHBNLLKOBJ;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T PLHLEFEBMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xEA0F90", Offset = "0xE9FD90", VA = "0x180EA0F90", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5230250", Offset = "0x522F050", VA = "0x185230250", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool ICFJMGAAFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x52300E0", Offset = "0x522EEE0", VA = "0x1852300E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object CNEMBBNCEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x522F5C0", Offset = "0x522E3C0", VA = "0x18522F5C0")]
	public bool ACMJDELJLOF(T HGMAIPELJHM, object OBGCPOCPFIJ, int JFELCJGHJPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5230140", Offset = "0x522EF40", VA = "0x185230140")]
	public bool KMCKMJIAHCE(object OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x522FC90", Offset = "0x522EA90", VA = "0x18522FC90")]
	public bool CFOKPIKBEGL(object OBGCPOCPFIJ, [Out] T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x52300B0", Offset = "0x522EEB0", VA = "0x1852300B0")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x52305C0", Offset = "0x522F3C0", VA = "0x1852305C0")]
	private bool MBNHHGNAIOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5232D20", Offset = "0x5231B20", VA = "0x185232D20")]
	public INGLKBMOAOH()
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
