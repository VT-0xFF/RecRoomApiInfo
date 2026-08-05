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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x77DCFA0", Offset = "0x77DC3A0", VA = "0x1877DCFA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JFHOBODPFBB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F20DC0", Offset = "0x1F201C0", VA = "0x181F20DC0")]
	public JFHOBODPFBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, KBMPGOOCHEA, MFHKCJLAAIO, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash PNBFDJGGCJP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xAF7D80", Offset = "0xAF7180", VA = "0x180AF7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x77DE1D0", Offset = "0x77DD5D0", VA = "0x1877DE1D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77DE190", Offset = "0x77DD590", VA = "0x1877DE190")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77DE210", Offset = "0x77DD610", VA = "0x1877DE210")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77DE3C0", Offset = "0x77DD7C0", VA = "0x1877DE3C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77DE330", Offset = "0x77DD730", VA = "0x1877DE330")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE2E720", Offset = "0xE2DB20", VA = "0x180E2E720")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC80DD0", Offset = "0xC801D0", VA = "0x180C80DD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x77DE150", Offset = "0x77DD550", VA = "0x1877DE150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77DE2A0", Offset = "0x77DD6A0", VA = "0x1877DE2A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77DDBF0", Offset = "0x77DCFF0", VA = "0x1877DDBF0")]
	public void CopyBounds(SavedExtents JAPIEEBOJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77DE0A0", Offset = "0x77DD4A0", VA = "0x1877DE0A0")]
	public void SetLocalSpaceBounds(Bounds IOLGLCIKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x12F1EC0", Offset = "0x12F12C0", VA = "0x1812F1EC0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77DE090", Offset = "0x77DD490", VA = "0x1877DE090")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77DDC20", Offset = "0x77DD020", VA = "0x1877DDC20")]
	private void EKFNJEHDOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77DDE90", Offset = "0x77DD290", VA = "0x1877DDE90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77DD5B0", Offset = "0x77DC9B0", VA = "0x1877DD5B0")]
	public static void CalculateLocalBoundsFor(GameObject MKMGIAEJNDJ, [Out] Bounds IOLGLCIKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77DDDD0", Offset = "0x77DD1D0", VA = "0x1877DDDD0")]
	private static void JLAINLDGCIJ(Bounds NLOOBJLDIMA, Color AMLIHKJCCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77DE0C0", Offset = "0x77DD4C0", VA = "0x1877DE0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A02E0", Offset = "0x99F6E0", VA = "0x1809A02E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1755820", Offset = "0x1754C20", VA = "0x181755820")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x550D890", Offset = "0x550CC90", VA = "0x18550D890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public virtual void FEJAOCEMEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
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
	[JFHOBODPFBB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x550D400", Offset = "0x550C800", VA = "0x18550D400", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x550BFD0", Offset = "0x550B3D0", VA = "0x18550BFD0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x550D7B0", Offset = "0x550CBB0", VA = "0x18550D7B0")]
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
	private sealed class NCLKHNELBNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NCLKHNELBNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4FEC650", Offset = "0x4FEBA50", VA = "0x184FEC650")]
		internal int FHFEOBADIOB(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[JFHOBODPFBB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42C6CF0", Offset = "0x42C60F0", VA = "0x1842C6CF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x42C6D50", Offset = "0x42C6150", VA = "0x1842C6D50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x42C6BD0", Offset = "0x42C5FD0", VA = "0x1842C6BD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MCBJECJLDOM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x42C6C90", Offset = "0x42C6090", VA = "0x1842C6C90", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x42C6A80", Offset = "0x42C5E80", VA = "0x1842C6A80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x42C6720", Offset = "0x42C5B20", VA = "0x1842C6720", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x42C5AE0", Offset = "0x42C4EE0", VA = "0x1842C5AE0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x42C5A10", Offset = "0x42C4E10", VA = "0x1842C5A10", Slot = "14")]
	protected virtual string ECHFADDBHDD(TKeyVal HJKENFLJHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42C5950", Offset = "0x42C4D50", VA = "0x1842C5950", Slot = "4")]
	public bool ContainsKey(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x42C6900", Offset = "0x42C5D00", VA = "0x1842C6900", Slot = "5")]
	public bool TryGetValue(TKey MCBJECJLDOM, [Out] TVal FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x42C5A40", Offset = "0x42C4E40", VA = "0x1842C5A40", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x42C5A40", Offset = "0x42C4E40", VA = "0x1842C5A40", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x42C6960", Offset = "0x42C5D60", VA = "0x1842C6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
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
		[Cpp2IlInjected.Address(RVA = "0x41C9C80", Offset = "0x41C9080", VA = "0x1841C9C80")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[JFHOBODPFBB]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x550F240", Offset = "0x550E640", VA = "0x18550F240")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x550EA80", Offset = "0x550DE80", VA = "0x18550EA80", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x550E030", Offset = "0x550D430", VA = "0x18550E030", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class ILLGHNFPJPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PLDJECNHEOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T HNMCNCHEPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float ONAKLKNBALG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int IGEIAKFMOHD = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float LHMLACJFPBO = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly PLDJECNHEOJ[] KCPGIJAPEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int FIGFBPOCGPP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float AMOFANMKBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB6E0D0", Offset = "0xB6D4D0", VA = "0x180B6E0D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBADC60", Offset = "0xBAD060", VA = "0x180BADC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T KJGDHEBJOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49D84B0", Offset = "0x49D78B0", VA = "0x1849D84B0")]
	protected ILLGHNFPJPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49D84F0", Offset = "0x49D78F0", VA = "0x1849D84F0")]
	protected ILLGHNFPJPC(int EOKAMHLPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49D8280", Offset = "0x49D7680", VA = "0x1849D8280")]
	public void LLICHLCEEGA(float AKIEJPDFOGK, T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool APALKBABBMD(float DJIHPGNCNNB, float OLLJNOFGIPE, [Out] T FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool GPKEFMLDGJP(float DJIHPGNCNNB, float OLLJNOFGIPE, [Out] T FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49D8210", Offset = "0x49D7610", VA = "0x1849D8210")]
	public void GAPBPDEBKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IMGPBEBMAOC : ILLGHNFPJPC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x77DC0D0", Offset = "0x77DB4D0", VA = "0x1877DC0D0", Slot = "4")]
	public override bool APALKBABBMD(float DJIHPGNCNNB, float OLLJNOFGIPE, [Out] Vector3 FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x77DC230", Offset = "0x77DB630", VA = "0x1877DC230", Slot = "5")]
	public override bool GPKEFMLDGJP(float DJIHPGNCNNB, float OLLJNOFGIPE, [Out] Vector3 FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x77DC370", Offset = "0x77DB770", VA = "0x1877DC370")]
	public IMGPBEBMAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LEIPCOKCHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36BC640", Offset = "0x36BBA40", VA = "0x1836BC640")]
	public static LAEFGAHHPJM<T1, T2> DCJNBNANGBG<T1, T2>(T1 PGFNDGHFAPP, T2 HFGKNMLPGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36BC6E0", Offset = "0x36BBAE0", VA = "0x1836BC6E0")]
	public static ENMPBGMNCJA<T1, T2, T3> DCJNBNANGBG<T1, T2, T3>(T1 PGFNDGHFAPP, T2 HFGKNMLPGFB, T3 COGIENMEPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4FD42A0", Offset = "0x4FD36A0", VA = "0x184FD42A0")]
	internal static int CJLEGGFIOPK(int DOOIMOFFBDL, int GKJKMBIEHEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A43F60", Offset = "0x6A43360", VA = "0x186A43F60")]
	internal static int CJLEGGFIOPK(int DOOIMOFFBDL, int GKJKMBIEHEO, int COPDABOOONG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LAEFGAHHPJM<T1, T2> : IComparable<LAEFGAHHPJM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 PGCHEOGAPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 BKGEPBDHLKM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4D6D0A0", Offset = "0x4D6C4A0", VA = "0x184D6D0A0")]
	public LAEFGAHHPJM(T1 PGFNDGHFAPP, T2 HFGKNMLPGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D6B280", Offset = "0x4D6A680", VA = "0x184D6B280", Slot = "4")]
	public int CompareTo(LAEFGAHHPJM<T1, T2> JAPIEEBOJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4D6BEE0", Offset = "0x4D6B2E0", VA = "0x184D6BEE0", Slot = "0")]
	public override bool Equals(object JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C480", Offset = "0x4D6B880", VA = "0x184D6C480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C910", Offset = "0x4D6BD10", VA = "0x184D6C910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ENMPBGMNCJA<T1, T2, T3> : IComparable<ENMPBGMNCJA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 PGCHEOGAPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 BKGEPBDHLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 DGECILLLJJO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x42A0D00", Offset = "0x42A0100", VA = "0x1842A0D00")]
	public ENMPBGMNCJA(T1 PGFNDGHFAPP, T2 HFGKNMLPGFB, T3 COGIENMEPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x42A04F0", Offset = "0x429F8F0", VA = "0x1842A04F0", Slot = "4")]
	public int CompareTo(ENMPBGMNCJA<T1, T2, T3> JAPIEEBOJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x42A0640", Offset = "0x429FA40", VA = "0x1842A0640", Slot = "0")]
	public override bool Equals(object JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x42A0910", Offset = "0x429FD10", VA = "0x1842A0910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x42A0B50", Offset = "0x429FF50", VA = "0x1842A0B50", Slot = "3")]
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
	public AnimationCurve PFFCHNNCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T NNBFNCDMGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xE610B0", Offset = "0xE604B0", VA = "0x180E610B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T HOCCALKMGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB47C60", Offset = "0xB47060", VA = "0x180B47C60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x29F47B0", Offset = "0x29F3BB0", VA = "0x1829F47B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x29F46D0", Offset = "0x29F3AD0", VA = "0x1829F46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float JFMEIDKPHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB40D00", Offset = "0xB40100", VA = "0x180B40D00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x579F1E0", Offset = "0x579E5E0", VA = "0x18579F1E0")]
	public T GBBIKPEMIFF(float CFOOONLCHLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x579F600", Offset = "0x579EA00", VA = "0x18579F600")]
	public T KNJOKJEFFGH(float CFOOONLCHLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GPKGBLDPPMF(T ONMPMLDKLEL, T CEMDANFAAHB, float CFOOONLCHLJ);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x77DAD70", Offset = "0x77DA170", VA = "0x1877DAD70", Slot = "4")]
	protected override float GPKGBLDPPMF(float ONMPMLDKLEL, float CEMDANFAAHB, float CFOOONLCHLJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x77DADB0", Offset = "0x77DA1B0", VA = "0x1877DADB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x15CF2E0", Offset = "0x15CE6E0", VA = "0x1815CF2E0", Slot = "4")]
	protected override Vector3 GPKGBLDPPMF(Vector3 ONMPMLDKLEL, Vector3 CEMDANFAAHB, float CFOOONLCHLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x77DF190", Offset = "0x77DE590", VA = "0x1877DF190")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x77D8D10", Offset = "0x77D8110", VA = "0x1877D8D10", Slot = "4")]
	protected override Color GPKGBLDPPMF(Color ONMPMLDKLEL, Color CEMDANFAAHB, float CFOOONLCHLJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x77D8DD0", Offset = "0x77D81D0", VA = "0x1877D8DD0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NBKPGDFFGII : AMDNAFLEPCJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x77DCD40", Offset = "0x77DC140", VA = "0x1877DCD40")]
	public NBKPGDFFGII(int MFDGLHBGGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x77DCCD0", Offset = "0x77DC0D0", VA = "0x1877DCCD0", Slot = "6")]
	protected override uint GJOJIEPAJLG(uint PNBFDJGGCJP, string FIIKLGCIAGG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CIPGPMAADGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable DMADMDPHOOL;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public CIPGPMAADGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FBODICNILCH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PDMBHHCPKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KPFBKNKADBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ODOGPLCKGMH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x46C11D0", Offset = "0x46C05D0", VA = "0x1846C11D0")]
	private FBODICNILCH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OFOEKDGGMAN, int CHAGEENGIKO, int LEHDLLJHLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x46BECB0", Offset = "0x46BE0B0", VA = "0x1846BECB0")]
	public static FBODICNILCH<T> AFLKMMODJAC()
	{
		return default(FBODICNILCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x46BF550", Offset = "0x46BE950", VA = "0x1846BF550")]
	public (int, int, Task<T>) HIMBDLCMDHK(int CGDOJFDLEME, [Optional] CancellationToken BLABAMPAGAH, double LLAIDEDFOJF = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x46BF340", Offset = "0x46BE740", VA = "0x1846BF340")]
	public void BDPIKMKMANP(int CGDOJFDLEME, int LEHDLLJHLDN, [In] T KGODHHBLJOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KICKBEHJNJM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x77DC960", Offset = "0x77DBD60", VA = "0x1877DC960")]
	public static FBODICNILCH<DKANDHFOMPH> AFLKMMODJAC()
	{
		return default(FBODICNILCH<DKANDHFOMPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x77DC9B0", Offset = "0x77DBDB0", VA = "0x1877DC9B0")]
	public static void BDPIKMKMANP([In] this FBODICNILCH<DKANDHFOMPH> CAMFIHKHJNG, int CGDOJFDLEME, int LEHDLLJHLDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class PLPEPNLAPAF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> MDGCBFMDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> IFGBDABEDBF;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3E73790", Offset = "0x3E72B90", VA = "0x183E73790", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GKMGMAJNIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> CHBNKJJCBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4712620", Offset = "0x4711A20", VA = "0x184712620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> LDOFPMHDPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4A23750", Offset = "0x4A22B50", VA = "0x184A23750", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x52F0AC0", Offset = "0x52EFEC0", VA = "0x1852F0AC0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x52F0B60", Offset = "0x52EFF60", VA = "0x1852F0B60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x52F05C0", Offset = "0x52EF9C0", VA = "0x1852F05C0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x52EFE20", Offset = "0x52EF220", VA = "0x1852EFE20", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x52F08F0", Offset = "0x52EFCF0", VA = "0x1852F08F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x52EFDD0", Offset = "0x52EF1D0", VA = "0x1852EFDD0", Slot = "9")]
	public void Add(TKey MCBJECJLDOM, TVal FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x52EFD30", Offset = "0x52EF130", VA = "0x1852EFD30", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x52EFEC0", Offset = "0x52EF2C0", VA = "0x1852EFEC0", Slot = "8")]
	public bool ContainsKey(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF50", Offset = "0x52EF350", VA = "0x1852EFF50", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x52F0820", Offset = "0x52EFC20", VA = "0x1852F0820", Slot = "10")]
	public bool Remove(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x52F07E0", Offset = "0x52EFBE0", VA = "0x1852F07E0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x52F0940", Offset = "0x52EFD40", VA = "0x1852F0940", Slot = "11")]
	public bool TryGetValue(TKey MCBJECJLDOM, [Out] TVal FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x52F0240", Offset = "0x52EF640", VA = "0x1852F0240", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF90", Offset = "0x52EF390", VA = "0x1852EFF90", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KCPGIJAPEHH, int PLNJMGKPKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x52F02E0", Offset = "0x52EF6E0", VA = "0x1852F02E0")]
	public bool HNOOOLJPLPG(TVal MCBJECJLDOM, [Out] TKey FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x52F0470", Offset = "0x52EF870", VA = "0x1852F0470")]
	private void JHAJCGBAOIP(TKey MCBJECJLDOM, TVal NMBONOELKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x52F0620", Offset = "0x52EFA20", VA = "0x1852F0620")]
	private void NGICGAFIBII(TKey MCBJECJLDOM, TVal NMBONOELKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x52F0120", Offset = "0x52EF520", VA = "0x1852F0120")]
	private bool EHBDNDLGNMN(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x52F09A0", Offset = "0x52EFDA0", VA = "0x1852F09A0")]
	public PLPEPNLAPAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class HNBGIJJDEBF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HNBGIJJDEBF<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x431B450", Offset = "0x431A850", VA = "0x18431B450", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x432C3F0", Offset = "0x432B7F0", VA = "0x18432C3F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x432D480", Offset = "0x432C880", VA = "0x18432D480")]
		public Enumerator(HNBGIJJDEBF<T> GODPNOEEIEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x432AD80", Offset = "0x432A180", VA = "0x18432AD80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x432BEA0", Offset = "0x432B2A0", VA = "0x18432BEA0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x432A9F0", Offset = "0x4329DF0", VA = "0x18432A9F0")]
		private void JMHKHFNBJIA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] AHIADGNGGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int FOGJBEMBBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PECLBOLKGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int DFDKLALNEIC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x489D3B0", Offset = "0x489C7B0", VA = "0x18489D3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x489E7C0", Offset = "0x489DBC0", VA = "0x18489E7C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x489DF80", Offset = "0x489D380", VA = "0x18489DF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x489F540", Offset = "0x489E940", VA = "0x18489F540")]
	public HNBGIJJDEBF(int MFDGLHBGGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x489E130", Offset = "0x489D530", VA = "0x18489E130")]
	public void LLICHLCEEGA(T CFOOONLCHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x489DD90", Offset = "0x489D190", VA = "0x18489DD90")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x489DCC0", Offset = "0x489D0C0", VA = "0x18489DCC0")]
	public void EOCHLDGLCMI(int PPLOBPJCNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x489DB20", Offset = "0x489CF20", VA = "0x18489DB20")]
	public void CINELLCKMFL(T[] KCPGIJAPEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x489EA60", Offset = "0x489DE60", VA = "0x18489EA60")]
	public Enumerator NHFIHKFCIDL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x489F480", Offset = "0x489E880", VA = "0x18489F480", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x489F480", Offset = "0x489E880", VA = "0x18489F480", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x489F000", Offset = "0x489E400", VA = "0x18489F000")]
	private int OJMIPMHGPJF(int KDCAMOIGIMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x489DC90", Offset = "0x489D090", VA = "0x18489DC90")]
	private int EJJAJOPCDBL(int KDCAMOIGIMA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OHPHDKKOKNP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> GLLALCPMCJD(TRequest INLHACAOAMD, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum PAFAMEDMMIH
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class LIGANCGDKCP
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float NCBADMMGAMH = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan PJKBHIGHCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int NIKBNPBFMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PAFAMEDMMIH JNHFPEHPPMP;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly LIGANCGDKCP OCEPFJKKOBL;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float GNNHHEKPGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4D88ED0", Offset = "0x4D882D0", VA = "0x184D88ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan GBJHMGOMNMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4D88FB0", Offset = "0x4D883B0", VA = "0x184D88FB0")]
		public LIGANCGDKCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct PNKBEIAPMAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest INLHACAOAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken BLABAMPAGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> CGFKCEOJNHD;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x52F6FA0", Offset = "0x52F63A0", VA = "0x1852F6FA0")]
		public PNKBEIAPMAH(TRequest INLHACAOAMD, TaskCompletionSource<TResult> CGFKCEOJNHD, CancellationToken BLABAMPAGAH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct HDPJDJCHIAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OHPHDKKOKNP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x487AF00", Offset = "0x487A300", VA = "0x18487AF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x487B700", Offset = "0x487AB00", VA = "0x18487B700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct PNHAGOELKOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OHPHDKKOKNP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PNKBEIAPMAH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x52F5A50", Offset = "0x52F4E50", VA = "0x1852F5A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x52F6CE0", Offset = "0x52F60E0", VA = "0x1852F6CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource ALCOKMFHCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<PNKBEIAPMAH> KFJCFLMOBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LIGANCGDKCP IOCACNOGHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GLLALCPMCJD BCEDMCKOJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task OJFOODCIMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int POLKPECJOIO;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x515E7F0", Offset = "0x515DBF0", VA = "0x18515E7F0")]
	public OHPHDKKOKNP(GLLALCPMCJD BCEDMCKOJEK, [Optional] LIGANCGDKCP IOCACNOGHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x515DC90", Offset = "0x515D090", VA = "0x18515DC90")]
	public Task<TResult> JJFDGIFCKCK(TRequest INLHACAOAMD, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x515DAE0", Offset = "0x515CEE0", VA = "0x18515DAE0")]
	private void IGBANBLDNJG(PNKBEIAPMAH NGBMLMJFFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x515CCB0", Offset = "0x515C0B0", VA = "0x18515CCB0")]
	[AsyncStateMachine(typeof(OHPHDKKOKNP<, >.HDPJDJCHIAP))]
	private Task AKCKKCGOCCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x515D170", Offset = "0x515C570", VA = "0x18515D170")]
	private PNKBEIAPMAH FMOIMGMJLBJ()
	{
		return default(PNKBEIAPMAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x515CE90", Offset = "0x515C290", VA = "0x18515CE90")]
	[AsyncStateMachine(typeof(OHPHDKKOKNP<, >.PNHAGOELKOA))]
	private Task FCLNJBKINLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x515E460", Offset = "0x515D860", VA = "0x18515E460")]
	private void PJKEDEOBCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x515CE50", Offset = "0x515C250", VA = "0x18515CE50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class FIBPFCPEMDL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> JMHKEMEJOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> DHKDBJHDJIJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E73790", Offset = "0x3E72B90", VA = "0x183E73790", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GKMGMAJNIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x38DF1D0", Offset = "0x38DE5D0", VA = "0x1838DF1D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x46E51F0", Offset = "0x46E45F0", VA = "0x1846E51F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x46E4560", Offset = "0x46E3960", VA = "0x1846E4560", Slot = "11")]
	public void Add(T DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x46E4B70", Offset = "0x46E3F70", VA = "0x1846E4B70")]
	public bool PNHHACKNDBJ(T DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x46E4FD0", Offset = "0x46E43D0", VA = "0x1846E4FD0", Slot = "15")]
	public bool Remove(T DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x46E46F0", Offset = "0x46E3AF0", VA = "0x1846E46F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x46E5090", Offset = "0x46E4490", VA = "0x1846E5090", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x46E45A0", Offset = "0x46E39A0", VA = "0x1846E45A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x46E4640", Offset = "0x46E3A40", VA = "0x1846E4640", Slot = "13")]
	public bool Contains(T DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46E4690", Offset = "0x46E3A90", VA = "0x1846E4690", Slot = "14")]
	public void CopyTo(T[] KCPGIJAPEHH, int PLNJMGKPKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x46E4780", Offset = "0x46E3B80", VA = "0x1846E4780", Slot = "6")]
	public int IndexOf(T DENKIGKMPCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x46E47E0", Offset = "0x46E3BE0", VA = "0x1846E47E0", Slot = "7")]
	public void Insert(int KDCAMOIGIMA, T DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x46E4C70", Offset = "0x46E4070", VA = "0x1846E4C70", Slot = "8")]
	public void RemoveAt(int KDCAMOIGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x46E50D0", Offset = "0x46E44D0", VA = "0x1846E50D0")]
	public FIBPFCPEMDL()
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
			[Cpp2IlInjected.Address(RVA = "0x2875FC0", Offset = "0x28753C0", VA = "0x182875FC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x23BA840", Offset = "0x23B9C40", VA = "0x1823BA840")]
		public SerializedGuid([In] Guid IIBHEJCKGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x77DE6E0", Offset = "0x77DDAE0", VA = "0x1877DE6E0")]
		public static SerializedGuid PMNEADMJNLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x77DE450", Offset = "0x77DD850", VA = "0x1877DE450")]
		public static SerializedGuid ALKONJLPDKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x77DE5D0", Offset = "0x77DD9D0", VA = "0x1877DE5D0")]
		public bool JKHINNGGCOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x77DE6B0", Offset = "0x77DDAB0", VA = "0x1877DE6B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x77DE630", Offset = "0x77DDA30", VA = "0x1877DE630", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x77DE4F0", Offset = "0x77DD8F0", VA = "0x1877DE4F0", Slot = "7")]
		public bool Equals(SerializedGuid JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x77DE530", Offset = "0x77DD930", VA = "0x1877DE530", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x77DE5C0", Offset = "0x77DD9C0", VA = "0x1877DE5C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x77DE4C0", Offset = "0x77DD8C0", VA = "0x1877DE4C0", Slot = "6")]
		public int CompareTo(SerializedGuid JAPIEEBOJEA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BNGFPBNDEPG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type FBCJMJDHIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string PEMPEMDENGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool FEMEFLFHNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool OKPMKGCJOKA;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x77D8B40", Offset = "0x77D7F40", VA = "0x1877D8B40")]
	public BNGFPBNDEPG(Type FAOIGCEDHCN, string PANACDMOLLH, bool AFKKKHOBBOI = false, bool BOAHLGHPCHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IEEPNPJOOFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int NBCMIBLCLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> PKFCELDACGM(float AKIEJPDFOGK, [Optional] float? AMOKOMLAOIG);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFLLGHPDMNF(float AKIEJPDFOGK, T FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GAPBPDEBKKO();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class KKJPAJHEAOE<T> : IEEPNPJOOFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class KOMJIEJJJKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float NHOMJLBLCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T HNMCNCHEPGK;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public KOMJIEJJJKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HNFCFLFHBKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public HNFCFLFHBKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x48A0650", Offset = "0x489FA50", VA = "0x1848A0650")]
		internal bool NDDCNHPEBAA(KOMJIEJJJKF sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float NINKJBNKBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float PDMEPAFPEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<KOMJIEJJJKF> EMHFFDJNIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NONJAPDNAMF<KOMJIEJJJKF> OIHCHAKKCAK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NBCMIBLCLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4CDAEE0", Offset = "0x4CDA2E0", VA = "0x184CDAEE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4CDB630", Offset = "0x4CDAA30", VA = "0x184CDB630")]
	public KKJPAJHEAOE(float IHBFPDEHKKF, float HHFDNIDJHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4CDAA30", Offset = "0x4CD9E30", VA = "0x184CDAA30", Slot = "6")]
	public bool CFLLGHPDMNF(float AKIEJPDFOGK, T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4CDB2C0", Offset = "0x4CDA6C0", VA = "0x184CDB2C0", Slot = "5")]
	public IEnumerable<T> PKFCELDACGM(float AKIEJPDFOGK, float? AMOKOMLAOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4CDADC0", Offset = "0x4CDA1C0", VA = "0x184CDADC0", Slot = "7")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4CDA880", Offset = "0x4CD9C80", VA = "0x184CDA880")]
	private void BHKKANFGDED(float AKIEJPDFOGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FNHBCCHFGJG<T> : IEEPNPJOOFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct BJGLJDODHCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T HNMCNCHEPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float NHOMJLBLCBM;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x46C16A0", Offset = "0x46C0AA0", VA = "0x1846C16A0")]
		public BJGLJDODHCK(T FIIKLGCIAGG, float AKIEJPDFOGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NCILGOFAEJO : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public FNHBCCHFGJG<T> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public NCILGOFAEJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4FE9210", Offset = "0x4FE8610", VA = "0x184FE9210", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4FE95F0", Offset = "0x4FE89F0", VA = "0x184FE95F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4FE94C0", Offset = "0x4FE88C0", VA = "0x184FE94C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x47D1940", Offset = "0x47D0D40", VA = "0x1847D1940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float IHBFPDEHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float HHFDNIDJHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<BJGLJDODHCK> EMHFFDJNIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FOGJBEMBBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int AJBJMHGMKDK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int NBCMIBLCLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x992560", Offset = "0x991960", VA = "0x180992560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x470E440", Offset = "0x470D840", VA = "0x18470E440")]
	public FNHBCCHFGJG(float IHBFPDEHKKF, float HHFDNIDJHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x470DA00", Offset = "0x470CE00", VA = "0x18470DA00", Slot = "6")]
	public bool CFLLGHPDMNF(float AKIEJPDFOGK, T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x470D700", Offset = "0x470CB00", VA = "0x18470D700", Slot = "8")]
	public int CFEEKJMJFLF(float AKIEJPDFOGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x470DF00", Offset = "0x470D300", VA = "0x18470DF00", Slot = "5")]
	[IteratorStateMachine(typeof(FNHBCCHFGJG<>.NCILGOFAEJO))]
	public IEnumerable<T> PKFCELDACGM(float AKIEJPDFOGK, float? AMOKOMLAOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x470DEA0", Offset = "0x470D2A0", VA = "0x18470DEA0", Slot = "7")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x470DCC0", Offset = "0x470D0C0", VA = "0x18470DCC0")]
	private void FDEIIDGAGPJ(float AKIEJPDFOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x470E140", Offset = "0x470D540", VA = "0x18470E140")]
	private BJGLJDODHCK PNOCOCHBILC()
	{
		return default(BJGLJDODHCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class HOEFFPEDKPI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct EGKGOEFFLOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long AOPHFADCNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long CPGNIMKILHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int FOEBEALKOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int JBKBFAAOFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool DINNANALJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string EILBAGBLFED;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4275F30", Offset = "0x4275330", VA = "0x184275F30")]
		public EGKGOEFFLOH(long AOPHFADCNHJ, int FOEBEALKOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4275F00", Offset = "0x4275300", VA = "0x184275F00")]
		public EGKGOEFFLOH(long AOPHFADCNHJ, long CPGNIMKILHH, int FOEBEALKOBE, int JBKBFAAOFGA, bool DINNANALJBC, string EILBAGBLFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4275EB0", Offset = "0x42752B0", VA = "0x184275EB0")]
		public int OLLINKNOEJC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4275DF0", Offset = "0x42751F0", VA = "0x184275DF0")]
		public int NINJAOJBMPB(int MLAOEJKHEEF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4275D90", Offset = "0x4275190", VA = "0x184275D90")]
		public double LNOACMMBLBD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4275E10", Offset = "0x4275210", VA = "0x184275E10")]
		public EGKGOEFFLOH OAKPIGFNLJE(long CPGNIMKILHH, int JBKBFAAOFGA)
		{
			return default(EGKGOEFFLOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class AEKMEBIOPMA : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct IGMJBEEODCJ<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AEKMEBIOPMA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<AEKMEBIOPMA, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private AEKMEBIOPMA <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x49D03A0", Offset = "0x49CF7A0", VA = "0x1849D03A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x46D85A0", Offset = "0x46D79A0", VA = "0x1846D85A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey CIMPFBFFMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly HOEFFPEDKPI<TKey> AOBIHHLEODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly ABDDJEPKCOD LEMJHEDOKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<AEKMEBIOPMA> MCIDKKOLPDI;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string MNNGHGOLEJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x426DD30", Offset = "0x426D130", VA = "0x18426DD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<AEKMEBIOPMA> CJOIABOADLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x48D76A0", Offset = "0x48D6AA0", VA = "0x1848D76A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public EGKGOEFFLOH IPHCNHENCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x48D7680", Offset = "0x48D6A80", VA = "0x1848D7680")]
			[CompilerGenerated]
			get
			{
				return default(EGKGOEFFLOH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x48D7AE0", Offset = "0x48D6EE0", VA = "0x1848D7AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x48D7B10", Offset = "0x48D6F10", VA = "0x1848D7B10")]
		internal AEKMEBIOPMA(HOEFFPEDKPI<TKey> AOBIHHLEODI, TKey MCBJECJLDOM, ABDDJEPKCOD LEMJHEDOKDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x48D7930", Offset = "0x48D6D30", VA = "0x1848D7930")]
		public AEKMEBIOPMA FDNNMEEFEGC(TKey MCBJECJLDOM, [Optional] ABDDJEPKCOD? ALPNHGJPKBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2CC71D0", Offset = "0x2CC65D0", VA = "0x182CC71D0")]
		[AsyncStateMachine(typeof(IGMJBEEODCJ<>))]
		public Task<T> EGAALNEFIPI<T>(TKey MCBJECJLDOM, Func<AEKMEBIOPMA, Task<T>> HGCIPPLBBMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x48D76E0", Offset = "0x48D6AE0", VA = "0x1848D76E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class KKMDIMNDJBG : IEnumerable<(TKey, List<TKey>, EGKGOEFFLOH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EGKGOEFFLOH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, EGKGOEFFLOH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public HOEFFPEDKPI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, EGKGOEFFLOH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, EGKGOEFFLOH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x285D150", Offset = "0x285C550", VA = "0x18285D150", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EGKGOEFFLOH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x4CDBCF0", Offset = "0x4CDB0F0", VA = "0x184CDBCF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x285D240", Offset = "0x285C640", VA = "0x18285D240")]
		[DebuggerHidden]
		public KKMDIMNDJBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4286490", Offset = "0x4285890", VA = "0x184286490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4CDB830", Offset = "0x4CDAC30", VA = "0x184CDB830", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4CDB7E0", Offset = "0x4CDABE0", VA = "0x184CDB7E0")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4CDBCA0", Offset = "0x4CDB0A0", VA = "0x184CDBCA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4CDBBD0", Offset = "0x4CDAFD0", VA = "0x184CDBBD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EGKGOEFFLOH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x46E4450", Offset = "0x46E3850", VA = "0x1846E4450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IBMKLKFKFBD : IEnumerable<(TKey, List<TKey>, EGKGOEFFLOH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EGKGOEFFLOH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, EGKGOEFFLOH timerEntry) <>2__current;

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
		private AEKMEBIOPMA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AEKMEBIOPMA <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HOEFFPEDKPI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<AEKMEBIOPMA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, EGKGOEFFLOH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, EGKGOEFFLOH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x285D150", Offset = "0x285C550", VA = "0x18285D150", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EGKGOEFFLOH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x49ACC50", Offset = "0x49AC050", VA = "0x1849ACC50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x285D240", Offset = "0x285C640", VA = "0x18285D240")]
		[DebuggerHidden]
		public IBMKLKFKFBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x49ACCB0", Offset = "0x49AC0B0", VA = "0x1849ACCB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x49AC2F0", Offset = "0x49AB6F0", VA = "0x1849AC2F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x49AC290", Offset = "0x49AB690", VA = "0x1849AC290")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x49AC230", Offset = "0x49AB630", VA = "0x1849AC230")]
		private void CHDBNOFNPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x49ACC00", Offset = "0x49AC000", VA = "0x1849ACC00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x49ACAC0", Offset = "0x49ABEC0", VA = "0x1849ACAC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EGKGOEFFLOH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x49ACBC0", Offset = "0x49ABFC0", VA = "0x1849ACBC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, EGKGOEFFLOH, ABDDJEPKCOD> BPEKHAEHNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, EGKGOEFFLOH, ABDDJEPKCOD> NLPDGGECNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<HOEFFPEDKPI<TKey>, ABDDJEPKCOD> OKALIOIJGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly AEKMEBIOPMA OCCCPPKDFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool AOPCOJBCAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int HBPBFAOHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch PPMMJBFNFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int CDKNBCCBHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string PAEJKMKPKDG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AEKMEBIOPMA NEHEGAOKJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string MNNGHGOLEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x48A1370", Offset = "0x48A0770", VA = "0x1848A1370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x48A1550", Offset = "0x48A0950", VA = "0x1848A1550")]
	public HOEFFPEDKPI(TKey CGCEDIHBKPK, ABDDJEPKCOD LEMJHEDOKDF, [Optional] int? FOEBEALKOBE, [Optional][CanBeNull] Stopwatch PPMMJBFNFNJ, [Optional] Action<TKey, EGKGOEFFLOH, ABDDJEPKCOD> BPEKHAEHNHE, [Optional] Action<TKey, EGKGOEFFLOH, ABDDJEPKCOD> NLPDGGECNBF, [Optional] Action<HOEFFPEDKPI<TKey>, ABDDJEPKCOD> OKALIOIJGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x48A1220", Offset = "0x48A0620", VA = "0x1848A1220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x48A13D0", Offset = "0x48A07D0", VA = "0x1848A13D0")]
	[IteratorStateMachine(typeof(HOEFFPEDKPI<>.KKMDIMNDJBG))]
	public IEnumerable<(TKey, List<TKey>, EGKGOEFFLOH)> PMJDHLMOMPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x48A1470", Offset = "0x48A0870", VA = "0x1848A1470")]
	[IteratorStateMachine(typeof(HOEFFPEDKPI<>.IBMKLKFKFBD))]
	private IEnumerable<(TKey, List<TKey>, EGKGOEFFLOH)> PMJDHLMOMPF(List<TKey> PMILCDIBAOD, AEKMEBIOPMA EIFGLEGDNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x48A12F0", Offset = "0x48A06F0", VA = "0x1848A12F0")]
	private (long, int) HMBELENFNOG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class JIDFACDNADD<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut NHJKGPNIGCO(HOEFFPEDKPI<TKey> AOBIHHLEODI);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	protected JIDFACDNADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class GKKPOBJKJBJ<TKey> : JIDFACDNADD<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string IDPNOOKNENG(TKey MCBJECJLDOM);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x482D100", Offset = "0x482C500", VA = "0x18482D100")]
	private static string DPJKIABLFGN(TKey MCBJECJLDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x482D290", Offset = "0x482C690", VA = "0x18482D290", Slot = "4")]
	public override string NHJKGPNIGCO(HOEFFPEDKPI<TKey> AOBIHHLEODI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x482D140", Offset = "0x482C540", VA = "0x18482D140")]
	public string NHJKGPNIGCO(HOEFFPEDKPI<TKey> AOBIHHLEODI, [NotNull] IDPNOOKNENG GIABDCINGJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string LGPHKOOMKGP(HOEFFPEDKPI<TKey> AOBIHHLEODI, [NotNull] IDPNOOKNENG GIABDCINGJP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x482D370", Offset = "0x482C770", VA = "0x18482D370")]
	protected GKKPOBJKJBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MGIMLIAEDNI<TKey> : JIDFACDNADD<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate string KCBFACBOLNE(TKey MCBJECJLDOM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string DEAFDILDABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double CGPEJOPIHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool COMELANPLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int LFMOLPPCLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> ELALKCNKLNE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B3F0", Offset = "0x4F8A7F0", VA = "0x184F8B3F0")]
	private static string DPJKIABLFGN(TKey MCBJECJLDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4F8BC30", Offset = "0x4F8B030", VA = "0x184F8BC30")]
	public MGIMLIAEDNI(string DEAFDILDABL = "F2", double CGPEJOPIHMH = double.MaxValue, bool COMELANPLIF = false, int LFMOLPPCLEL = int.MaxValue, [Optional] ISet<string> ELALKCNKLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4F8BB50", Offset = "0x4F8AF50", VA = "0x184F8BB50", Slot = "4")]
	public override Dictionary<string, string> NHJKGPNIGCO(HOEFFPEDKPI<TKey> AOBIHHLEODI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B430", Offset = "0x4F8A830", VA = "0x184F8B430")]
	private bool FHNEKCOLMFP(string JOEBEPEDNNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B510", Offset = "0x4F8A910", VA = "0x184F8B510")]
	public Dictionary<string, string> NHJKGPNIGCO(HOEFFPEDKPI<TKey> AOBIHHLEODI, KCBFACBOLNE GIABDCINGJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B020", Offset = "0x4F8A420", VA = "0x184F8B020")]
	private string AHIMJIFCHGI(StringBuilder GEELAOGBFAD, List<TKey> OCICLLMLMPD, KCBFACBOLNE GIABDCINGJP, bool JJLLKLIBLNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B290", Offset = "0x4F8A690", VA = "0x184F8B290")]
	private static void BNDFHKHHPAK(StringBuilder MGIBHKFMPMK, string LALNJEIDJJE, bool MJGLGCCBBEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HLLEHHGDPCG<TKey> : GKKPOBJKJBJ<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ACOODGPEMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IDPNOOKNENG keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static HLLEHHGDPCG<TKey> DMADMDPHOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] OGEGACCCBBG;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4895770", Offset = "0x4894B70", VA = "0x184895770")]
	private HLLEHHGDPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x48947A0", Offset = "0x4893BA0", VA = "0x1848947A0", Slot = "5")]
	protected override string LGPHKOOMKGP(HOEFFPEDKPI<TKey> AOBIHHLEODI, IDPNOOKNENG GIABDCINGJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x48946A0", Offset = "0x4893AA0", VA = "0x1848946A0")]
	[CompilerGenerated]
	internal static string HDKCICNPPFB(string PLCFGICKLFP, TKey MCBJECJLDOM, ACOODGPEMBD P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class NHPFKAAJPHL : HOEFFPEDKPI<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class MIGJKAGHBBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<NHPFKAAJPHL, ABDDJEPKCOD> callback;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MIGJKAGHBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x77DCC40", Offset = "0x77DC040", VA = "0x1877DCC40")]
		internal void JDEOFPDDAPD(HOEFFPEDKPI<string> timer, ABDDJEPKCOD log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x77DCE50", Offset = "0x77DC250", VA = "0x1877DCE50")]
	public NHPFKAAJPHL(ABDDJEPKCOD LEMJHEDOKDF, [Optional] string CCGEFFLJOFG, [Optional] int? FOEBEALKOBE, [Optional] Stopwatch PPMMJBFNFNJ, [Optional] Action<string, EGKGOEFFLOH, ABDDJEPKCOD> BPEKHAEHNHE, [Optional] Action<string, EGKGOEFFLOH, ABDDJEPKCOD> NLPDGGECNBF, [Optional] Action<NHPFKAAJPHL, ABDDJEPKCOD> OKALIOIJGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x77DCD90", Offset = "0x77DC190", VA = "0x1877DCD90")]
	private static Action<HOEFFPEDKPI<string>, ABDDJEPKCOD> BNKGHNBOLEF(Action<NHPFKAAJPHL, ABDDJEPKCOD> FJLFOAFFGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public abstract class DNFBBLKCBOI
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class GJDJBHBMHHD : DNFBBLKCBOI
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static DNFBBLKCBOI DMADMDPHOOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x77DADF0", Offset = "0x77DA1F0", VA = "0x1877DADF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float IMEENKEODNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x10CB940", Offset = "0x10CAD40", VA = "0x1810CB940", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x77DAEE0", Offset = "0x77DA2E0", VA = "0x1877DAEE0")]
		public GJDJBHBMHHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static DNFBBLKCBOI JOAADNFCHDI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static DNFBBLKCBOI OCEPFJKKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x77D8E10", Offset = "0x77D8210", VA = "0x1877D8E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float IMEENKEODNB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	protected DNFBBLKCBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface GCJENIKICGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool FNCFKFPOBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface FHGKGMPNNBH<T> : GCJENIKICGG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> MKHKEEKJGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	COLCOEKKCIF<T> ECLAOCOFLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class KAEJOELPGLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x36ADAB0", Offset = "0x36ACEB0", VA = "0x1836ADAB0")]
	public static FHGKGMPNNBH<TResource> CPBJIJFGMPL<TResource, TId>(this PABJKCBDJJA<TId, TResource> LPEBEIIGFNF, TId IIKCEJDFBDH, [Optional] Func<TId, CancellationToken, Task<TResource>>? MMFHNFHONLH) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class MOIEHIEKHKD
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class CBCANEGOMAH<T> : ELPAFLNKGMK<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> MKHKEEKJGPH
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override COLCOEKKCIF<T?> ECLAOCOFLOH
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x612CA40", Offset = "0x612BE40", VA = "0x18612CA40")]
		public CBCANEGOMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "10")]
		protected override void ECMAAOLAOMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class AIOIMGCFMON<T> : ELPAFLNKGMK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T CDFOGMGGJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? EDJGHPLHBMD;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> MKHKEEKJGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override COLCOEKKCIF<T> ECLAOCOFLOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x48E6340", Offset = "0x48E5740", VA = "0x1848E6340")]
		public AIOIMGCFMON(T KBIEIFLIPFC, Action<T>? EKMCBBBPJNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x48E6150", Offset = "0x48E5550", VA = "0x1848E6150", Slot = "10")]
		protected override void ECMAAOLAOMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class MJIHBCLDJEF<T> : ELPAFLNKGMK<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> MKHKEEKJGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override COLCOEKKCIF<T> ECLAOCOFLOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4F96310", Offset = "0x4F95710", VA = "0x184F96310")]
		public MJIHBCLDJEF(Exception MIJGFNBACFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "10")]
		protected override void ECMAAOLAOMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class KICHNALDHLK<T> : ELPAFLNKGMK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct KGBPMMONIEJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<FHGKGMPNNBH<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<FHGKGMPNNBH<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4CD0D90", Offset = "0x4CD0190", VA = "0x184CD0D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4CD1290", Offset = "0x4CD0690", VA = "0x184CD1290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct EGOAPCNKIFL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<FHGKGMPNNBH<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<FHGKGMPNNBH<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4276930", Offset = "0x4275D30", VA = "0x184276930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4276BC0", Offset = "0x4275FC0", VA = "0x184276BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<FHGKGMPNNBH<T>> MENIGLLFGJD;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> MKHKEEKJGPH
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override COLCOEKKCIF<T> ECLAOCOFLOH
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5D60", Offset = "0x4CD5160", VA = "0x184CD5D60")]
		public KICHNALDHLK(Task<FHGKGMPNNBH<T>> ALKPEINKLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5960", Offset = "0x4CD4D60", VA = "0x184CD5960", Slot = "10")]
		protected override void ECMAAOLAOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5BF0", Offset = "0x4CD4FF0", VA = "0x184CD5BF0")]
		[AsyncStateMachine(typeof(KICHNALDHLK<>.KGBPMMONIEJ))]
		[CompilerGenerated]
		internal static Task<T> MAIIILACIBG(Task<FHGKGMPNNBH<T>> ALKPEINKLAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5880", Offset = "0x4CD4C80", VA = "0x184CD5880")]
		[AsyncStateMachine(typeof(KICHNALDHLK<>.EGOAPCNKIFL))]
		[CompilerGenerated]
		internal static Task CCFOLNHJECC(Task<FHGKGMPNNBH<T>> ALKPEINKLAJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class PJLPOOAEEOO<TIn, TOut> : ELPAFLNKGMK<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct FMJAILIJKKI : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x470BCC0", Offset = "0x470B0C0", VA = "0x18470BCC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x46E8BE0", Offset = "0x46E7FE0", VA = "0x1846E8BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly FHGKGMPNNBH<TIn> BOFKKHIMNBO;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> MKHKEEKJGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override COLCOEKKCIF<TOut> ECLAOCOFLOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x52E3750", Offset = "0x52E2B50", VA = "0x1852E3750")]
		public PJLPOOAEEOO(FHGKGMPNNBH<TIn> DFNBOEIKBMA, Func<TIn, TOut> PCJLJEGECPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x52E3400", Offset = "0x52E2800", VA = "0x1852E3400", Slot = "10")]
		protected override void ECMAAOLAOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x52E35D0", Offset = "0x52E29D0", VA = "0x1852E35D0")]
		[AsyncStateMachine(typeof(PJLPOOAEEOO<, >.FMJAILIJKKI))]
		[CompilerGenerated]
		internal static Task<TOut> MBPCLCLCPML(Task<TIn> CCKCANLHMBJ, Func<TIn, TOut> PCJLJEGECPE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3705730", Offset = "0x3704B30", VA = "0x183705730")]
	public static FHGKGMPNNBH<T> OGOLFLHIENG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3705680", Offset = "0x3704A80", VA = "0x183705680")]
	public static FHGKGMPNNBH<T> LABNBDKBGCD<T>(T KGODHHBLJOE, [Optional] Action<T>? EKMCBBBPJNF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x363C7F0", Offset = "0x363BBF0", VA = "0x18363C7F0")]
	public static FHGKGMPNNBH<T> PDNBEKINKGN<T>(Exception MIJGFNBACFK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x363C7F0", Offset = "0x363BBF0", VA = "0x18363C7F0")]
	public static FHGKGMPNNBH<T> JOCIAFEKCGP<T>(Task<FHGKGMPNNBH<T>> ALKPEINKLAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x364C040", Offset = "0x364B440", VA = "0x18364C040")]
	public static FHGKGMPNNBH<TOut> GFBMHFBKABC<TOut, TIn>(FHGKGMPNNBH<TIn> ENGGEIHHCEE, Func<TIn, TOut> PCJLJEGECPE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class ELPAFLNKGMK<T> : FHGKGMPNNBH<T>, GCJENIKICGG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string ILECMOBOMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly KNNGNCINDND COPFGAKLBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool AOPCOJBCAIK;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool FNCFKFPOBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xBD2670", Offset = "0xBD1A70", VA = "0x180BD2670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> MKHKEEKJGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract COLCOEKKCIF<T> ECLAOCOFLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x429EE10", Offset = "0x429E210", VA = "0x18429EE10")]
	public ELPAFLNKGMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x429EB00", Offset = "0x429DF00", VA = "0x18429EB00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void ECMAAOLAOMM();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class NCLNOPENJIK<TTask, T> : ELPAFLNKGMK<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GLEHECPBNPI
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
			public GLEHECPBNPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3E61DC0", Offset = "0x3E611C0", VA = "0x183E61DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3E62310", Offset = "0x3E61710", VA = "0x183E62310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public NCLNOPENJIK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GLEHECPBNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x482D820", Offset = "0x482CC20", VA = "0x18482D820")]
		[AsyncStateMachine(typeof(NCLNOPENJIK<, >.GLEHECPBNPI.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> ONIIFHDPKMO(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> ALKPEINKLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource CGAKGMDNBAB;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> MKHKEEKJGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override COLCOEKKCIF<T> ECLAOCOFLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4FECA60", Offset = "0x4FEBE60", VA = "0x184FECA60")]
	protected NCLNOPENJIK(TTask ALKPEINKLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4FEC810", Offset = "0x4FEBC10", VA = "0x184FEC810", Slot = "10")]
	protected override void ECMAAOLAOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T KIGINBMEIMN(TTask HKMAHIDKKII);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void EIABPGCJPCK();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BIAHJFJLGNN<T> : ELPAFLNKGMK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly IAMMFEOALJI<Task<T>> POEDLPCBLJN;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> MKHKEEKJGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x48744A0", Offset = "0x48738A0", VA = "0x1848744A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override COLCOEKKCIF<T> ECLAOCOFLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5D60DA0", Offset = "0x5D601A0", VA = "0x185D60DA0")]
	public BIAHJFJLGNN(IAMMFEOALJI<Task<T>> IKCPCECKDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5D60D80", Offset = "0x5D60180", VA = "0x185D60D80", Slot = "10")]
	protected override void ECMAAOLAOMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FAMENKPKKOJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName FFBAGCPAJBE;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> EBCMHDJAGFP;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x77D9FE0", Offset = "0x77D93E0", VA = "0x1877D9FE0")]
	public static int AJOBICJAEAF(this KBMPGOOCHEA MKNCIACPBFE, IncrementalHash PNBFDJGGCJP, byte[] KNAAKBGMPAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x77DA730", Offset = "0x77D9B30", VA = "0x1877DA730")]
	public static bool IHEKDGKNDEI([CanBeNull] this KBMPGOOCHEA MKNCIACPBFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x77DA420", Offset = "0x77D9820", VA = "0x1877DA420")]
	public static bool IHEKDGKNDEI([CanBeNull] this KBMPGOOCHEA MKNCIACPBFE, [Out] string DFEFGBECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x77DA0F0", Offset = "0x77D94F0", VA = "0x1877DA0F0")]
	public static bool IHEKDGKNDEI([CanBeNull] this KBMPGOOCHEA MKNCIACPBFE, IncrementalHash PNBFDJGGCJP, byte[] KNAAKBGMPAJ, [Out] string DFEFGBECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x77DA060", Offset = "0x77D9460", VA = "0x1877DA060")]
	private static bool GOBEKEJOPAJ(byte[] HMJPHOHEJNN, Span<byte> HGAABFGPNHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FNEGDHCGGMD
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x77DAC20", Offset = "0x77DA020", VA = "0x1877DAC20")]
	public static int NCOJKGIOKLI(HashAlgorithmName MPEKOHAMOEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x77DA9C0", Offset = "0x77D9DC0", VA = "0x1877DA9C0")]
	public static int AJOBICJAEAF(this MFHKCJLAAIO OHOIJHAMFOD, byte[] FCOFGADJPMH, IncrementalHash PNBFDJGGCJP, byte[] KGCBIBONLAB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface MFHKCJLAAIO
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash PNBFDJGGCJP);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface KBMPGOOCHEA : MFHKCJLAAIO
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] LIPOHIKPAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] FJOPJEBLIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IEONNJMGILG
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool KNNHPNBIMDG;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> DIGBBHEKEDO;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> FGAOMEMCAEM;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding JEONGDBHCGE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> CBMOBBJDBHF;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3654250", Offset = "0x3653650", VA = "0x183654250")]
	public static void OFELMIMGBDL<T>(this IncrementalHash KNAEHPKBDGN, [CanBeNull] T EJFPPCHJOBM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3654310", Offset = "0x3653710", VA = "0x183654310")]
	public static void OJJKAKBIONJ<T>(this IncrementalHash KNAEHPKBDGN, [CanBeNull] T OHOIJHAMFOD) where T : MFHKCJLAAIO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3653D30", Offset = "0x3653130", VA = "0x183653D30")]
	public static void LGMLBOBHGPJ<T>(this IncrementalHash KNAEHPKBDGN, [CanBeNull] IList<T> FBIPIHLHAMB) where T : MFHKCJLAAIO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x77DB440", Offset = "0x77DA840", VA = "0x1877DB440")]
	private static bool DNOCPNOHCPN([CanBeNull] MFHKCJLAAIO OHOIJHAMFOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x77DB040", Offset = "0x77DA440", VA = "0x1877DB040")]
	public static void DMMDFKFLBDK(this IncrementalHash PNBFDJGGCJP, string? OIMLDGDGKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x77DB530", Offset = "0x77DA930", VA = "0x1877DB530")]
	public static void FELPCKIMFHM(this IncrementalHash PNBFDJGGCJP, long KJOMFFBBCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x77DBC30", Offset = "0x77DB030", VA = "0x1877DBC30")]
	public static void LNENGFEDOIO(this IncrementalHash PNBFDJGGCJP, int PDKNEECHPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x77DB830", Offset = "0x77DAC30", VA = "0x1877DB830")]
	public static void INIKHMMGENE(this IncrementalHash PNBFDJGGCJP, short PIPCGFPICJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x77DAF30", Offset = "0x77DA330", VA = "0x1877DAF30")]
	public static void ADBPPIDJDDF(this IncrementalHash PNBFDJGGCJP, byte LGDOLPINJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x77DBA00", Offset = "0x77DAE00", VA = "0x1877DBA00")]
	public static void KINFCPFPAJF(this IncrementalHash PNBFDJGGCJP, bool DEEJGPOPLNH, bool OGAIMPCNEBK = false, bool JJMMEPMCDDI = false, bool LMJPFCGEOIL = false, bool DPDIEMAAHEP = false, bool CINMEJHAFOF = false, bool KBMIPEBOPKB = false, bool MLDMMCHGJAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3653700", Offset = "0x3652B00", VA = "0x183653700")]
	public static void COLJPLPAJPP<T>(this IncrementalHash PNBFDJGGCJP, T KBBLKNKJAHB) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x77DBB70", Offset = "0x77DAF70", VA = "0x1877DBB70")]
	public static void LDEAGOKFOKJ(this IncrementalHash PNBFDJGGCJP, float BJNPPMKFNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x77DB4D0", Offset = "0x77DA8D0", VA = "0x1877DB4D0")]
	public static void EJCHFHKJFOI(this IncrementalHash PNBFDJGGCJP, ulong EHBEAKBIHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x77DBBD0", Offset = "0x77DAFD0", VA = "0x1877DBBD0")]
	public static void LIHJPPMGCND(this IncrementalHash PNBFDJGGCJP, uint DINPFLKPEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x77DBE00", Offset = "0x77DB200", VA = "0x1877DBE00")]
	public static void PDICBMEEGIA(this IncrementalHash PNBFDJGGCJP, ushort GOGMBBDJBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x77DB700", Offset = "0x77DAB00", VA = "0x1877DB700")]
	public static void IMLFDOEEHNB(this IncrementalHash PNBFDJGGCJP, Vector3 IHGONHLDFJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PDEJCEGBCFH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x77DD020", Offset = "0x77DC420", VA = "0x1877DD020")]
	public PDEJCEGBCFH(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class ENHMGDBDCAB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate void CLJCACEPICM(ushort OLHKJKNGAKB, ushort GNFMBPFIOBD, ushort BKHKKCGBKOI, ushort BNDAKHANCAG);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void FCCMKGPKCPB(ushort CCDPPEDDCIH, ushort PAJHHEGOJFI);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void BJBEFIAIJLI();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort DAMIHDHGJJE = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	protected ENHMGDBDCAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public abstract class NMKHFNBKKEM<T> : ENHMGDBDCAB where T : NMKHFNBKKEM<T>.CPIJPDONEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface CPIJPDONEHM
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		FCCMKGPKCPB CGIGAIFLGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		FCCMKGPKCPB KMOAEMCDGKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		BJBEFIAIJLI JACHNBEOLJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> GKLLPCCFKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BJBEFIAIJLI ADHPKKODECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private BJBEFIAIJLI OENCOBEJJPC;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool ACDMOMPLBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA110A0", Offset = "0xA104A0", VA = "0x180A110A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x996F20", Offset = "0x996320", VA = "0x180996F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort OIGKJPKJCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5037EA0", Offset = "0x50372A0", VA = "0x185037EA0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5037B60", Offset = "0x5036F60", VA = "0x185037B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort EKIFIDNNALK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5037DE0", Offset = "0x50371E0", VA = "0x185037DE0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5036EE0", Offset = "0x50362E0", VA = "0x185036EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort BGCALOLBIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD234A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xD241B0", Offset = "0xD235B0", VA = "0x180D241B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort GJCHNAMLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5037B50", Offset = "0x5036F50", VA = "0x185037B50")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5037C10", Offset = "0x5037010", VA = "0x185037C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool JOEFNLEBLCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1666830", Offset = "0x1665C30", VA = "0x181666830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool AKGNOPMIGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xDDB8A0", Offset = "0xDDACA0", VA = "0x180DDB8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CLJCACEPICM IBHDFFEFCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5037B70", Offset = "0x5036F70", VA = "0x185037B70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5037AB0", Offset = "0x5036EB0", VA = "0x185037AB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5037160", Offset = "0x5036560", VA = "0x185037160")]
	private T CGPOMAFMFCA(ushort JGMAGABKLLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5037EC0", Offset = "0x50372C0", VA = "0x185037EC0")]
	private T PGNMJLDJICE(ushort JGMAGABKLLJ, ushort PMJHGEIPANO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5037210", Offset = "0x5036610", VA = "0x185037210")]
	protected T DMINEDDOFPM(uint NAFDPDOMDOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5037F80", Offset = "0x5037380", VA = "0x185037F80")]
	protected NMKHFNBKKEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5037D90", Offset = "0x5037190", VA = "0x185037D90")]
	public void LCHIDODCJJI(ushort INBELDEJHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5037C20", Offset = "0x5037020", VA = "0x185037C20")]
	public void LCHIDODCJJI(ushort INBELDEJHLI, ushort JPAOFBKMECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5037C80", Offset = "0x5037080", VA = "0x185037C80", Slot = "4")]
	protected virtual void LCHIDODCJJI(uint KOPKGCGHIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5037280", Offset = "0x5036680", VA = "0x185037280")]
	protected void ELAINIAJJJA(uint KOPKGCGHIAD, uint AFFHGPOENDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5037DF0", Offset = "0x50371F0", VA = "0x185037DF0")]
	protected void MFGHHCILEDH(ushort JGMAGABKLLJ, ushort PMJHGEIPANO, T FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5036E80", Offset = "0x5036280", VA = "0x185036E80")]
	private void AGBAIINGILN(uint NAFDPDOMDOJ, T FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5036EF0", Offset = "0x50362F0", VA = "0x185036EF0")]
	protected void CCNFHGIPLMK(float NFEBFCGCNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5037EB0", Offset = "0x50372B0", VA = "0x185037EB0")]
	protected uint PANBAGEIDML(ushort JGMAGABKLLJ, ushort PMJHGEIPANO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5037DD0", Offset = "0x50371D0", VA = "0x185037DD0")]
	protected ushort LFDFOEFMIPP(uint LDCGLJJHGAC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5037270", Offset = "0x5036670", VA = "0x185037270")]
	protected ushort EIEEPFGNLIM(uint LDCGLJJHGAC)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class KIGMLMDDLNB : NMKHFNBKKEM<KIGMLMDDLNB.OBOCNJFIDLH>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class OBOCNJFIDLH : CPIJPDONEHM
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public FCCMKGPKCPB CGIGAIFLGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public FCCMKGPKCPB KMOAEMCDGKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public BJBEFIAIJLI JACHNBEOLJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OBOCNJFIDLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x77DCB60", Offset = "0x77DBF60", VA = "0x1877DCB60")]
	public void NFEOKLGHAPA(ushort JBOACBNKLLH, FCCMKGPKCPB LIIOBNJJIIN, FCCMKGPKCPB EJBLLALHLNN, BJBEFIAIJLI PDFHNJMKHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x77DCA80", Offset = "0x77DBE80", VA = "0x1877DCA80")]
	public void NFEOKLGHAPA(ushort JGMAGABKLLJ, ushort PMJHGEIPANO, FCCMKGPKCPB LIIOBNJJIIN, FCCMKGPKCPB EJBLLALHLNN, BJBEFIAIJLI PDFHNJMKHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x77DCA30", Offset = "0x77DBE30", VA = "0x1877DCA30")]
	public void NABACIPFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x77DC920", Offset = "0x77DBD20", VA = "0x1877DC920")]
	protected KIGMLMDDLNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class JAHAFOPLAPB : KIGMLMDDLNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool HMNABFCOFHI;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool NFLEONEBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xB54C50", Offset = "0xB54050", VA = "0x180B54C50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xC46830", Offset = "0xC45C30", VA = "0x180C46830")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x77DC860", Offset = "0x77DBC60", VA = "0x1877DC860")]
	public void MBHBIOMKKEG(ushort EDEKHGFOCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x77DC8C0", Offset = "0x77DBCC0", VA = "0x1877DC8C0")]
	public void MBHBIOMKKEG(ushort EDEKHGFOCED, ushort ECMEGHLFDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x77DC920", Offset = "0x77DBD20", VA = "0x1877DC920")]
	public JAHAFOPLAPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class KEEAKJGKGMC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class BHGKKAGKPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode CAMFIHKHJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode PBIFOHNGFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public JNLEFKJEHKC MLGOEAANOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<JNLEFKJEHKC> HNDCBIDICOK;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BHGKKAGKPEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct JNLEFKJEHKC : IComparable<JNLEFKJEHKC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int CCLELJLNNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant JKDFMBIMBCA;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1522D40", Offset = "0x1522140", VA = "0x181522D40")]
		public JNLEFKJEHKC(int CCLELJLNNPJ, TClaimant JKDFMBIMBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4C0BF40", Offset = "0x4C0B340", VA = "0x184C0BF40")]
		public bool BPODHOLPKBF([In] JNLEFKJEHKC JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4C0BFB0", Offset = "0x4C0B3B0", VA = "0x184C0BFB0")]
		public bool ILPMLCECOPA([In] JNLEFKJEHKC JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4C0BFA0", Offset = "0x4C0B3A0", VA = "0x184C0BFA0", Slot = "4")]
		public int CompareTo(JNLEFKJEHKC JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4C0BFC0", Offset = "0x4C0B3C0", VA = "0x184C0BFC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum NCNHDBNELEP
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PAGFDJFBGHK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public KEEAKJGKGMC<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public PAGFDJFBGHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x52C3D60", Offset = "0x52C3160", VA = "0x1852C3D60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x52C3F40", Offset = "0x52C3340", VA = "0x1852C3F40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x52C3E40", Offset = "0x52C3240", VA = "0x1852C3E40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x42868E0", Offset = "0x4285CE0", VA = "0x1842868E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly NONJAPDNAMF<BHGKKAGKPEN> MMGLCJDDKBH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly NONJAPDNAMF<List<JNLEFKJEHKC>> IAAEJNBHPEF;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int OLEJNLLMGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> HJIMNPLHBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, BHGKKAGKPEN> FAFNAMFGHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NCNHDBNELEP MBENOAGKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode BCNAMCMGPEJ(TNode JOMDOBIKCNM);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void KLDPLFICDKK(TNode JOMDOBIKCNM, TClaimant OKDHNEJCMMG, TClaimant MNCGOFEFLOI);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4CCDDF0", Offset = "0x4CCD1F0", VA = "0x184CCDDF0")]
	public KEEAKJGKGMC(NCNHDBNELEP MBENOAGKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4CCDB60", Offset = "0x4CCCF60", VA = "0x184CCDB60")]
	public void PHBKFKILIAI(TNode JOMDOBIKCNM, TNode DPOGHMAJNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC3D0", Offset = "0x4CCB7D0", VA = "0x184CCC3D0")]
	public void BEAFKLGBKCH(TClaimant JKDFMBIMBCA, TNode PKNADHOFMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC780", Offset = "0x4CCBB80", VA = "0x184CCC780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC300", Offset = "0x4CCB700", VA = "0x184CCC300")]
	private void AILBCLBICAN(TClaimant JKDFMBIMBCA, TNode FNNOIDFNBHH, TNode PKNADHOFMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD9A0", Offset = "0x4CCCDA0", VA = "0x184CCD9A0")]
	private int MGHCKHIHLCO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD250", Offset = "0x4CCC650", VA = "0x184CCD250")]
	private void IIFNFKPBOKA(TClaimant JKDFMBIMBCA, TNode DHAOOOCKNOL, TNode ANKBIEBHJJL, int FLJDFHABJBA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC550", Offset = "0x4CCB950", VA = "0x184CCC550")]
	private void CJLHJJODMJD(JNLEFKJEHKC POHEEFICGOO, BHGKKAGKPEN DBBKCMNDDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD5A0", Offset = "0x4CCC9A0", VA = "0x184CCD5A0")]
	private void ILGHCKINMKM(TClaimant JKDFMBIMBCA, TNode DHAOOOCKNOL, TNode ANKBIEBHJJL, int FLJDFHABJBA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC980", Offset = "0x4CCBD80", VA = "0x184CCC980")]
	private void EOKIGEJACMH(JNLEFKJEHKC POHEEFICGOO, TNode JOMDOBIKCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC620", Offset = "0x4CCBA20", VA = "0x184CCC620")]
	private void CLLEBBHHNEE(JNLEFKJEHKC POHEEFICGOO, BHGKKAGKPEN DBBKCMNDDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4CCDA10", Offset = "0x4CCCE10", VA = "0x184CCDA10")]
	private void NNBNKNCGKBC(BHGKKAGKPEN DBBKCMNDDPN, bool AHIMADPPHFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4CCCAB0", Offset = "0x4CCBEB0", VA = "0x184CCCAB0")]
	private void FIGCHNDHGJA(BHGKKAGKPEN DBBKCMNDDPN, TNode DPOGHMAJNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD160", Offset = "0x4CCC560", VA = "0x184CCD160")]
	[IteratorStateMachine(typeof(KEEAKJGKGMC<, >.PAGFDJFBGHK))]
	private IEnumerable<TNode> IAHGILKCFFK(TNode DHAOOOCKNOL, TNode ANKBIEBHJJL, bool MNFECKLIOGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD890", Offset = "0x4CCCC90", VA = "0x184CCD890")]
	private BHGKKAGKPEN ILKBFMJOKEE(TNode JOMDOBIKCNM, TNode PBIFOHNGFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4CCCFE0", Offset = "0x4CCC3E0", VA = "0x184CCCFE0")]
	private BHGKKAGKPEN GGPJKCIELEH(TNode JOMDOBIKCNM, TNode PBIFOHNGFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4CCCE20", Offset = "0x4CCC220", VA = "0x184CCCE20")]
	private void GAMNFLLKIAD(BHGKKAGKPEN DBBKCMNDDPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class AMDNAFLEPCJ<T> : IEnumerable<AMDNAFLEPCJ<T>.ECGKCDOMDCF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct ECGKCDOMDCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T FIIKLGCIAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int KDCAMOIGIMA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class JBENBPMPPGB : IEnumerator<ECGKCDOMDCF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private AMDNAFLEPCJ<T> EBAHFMPNPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int KDCAMOIGIMA;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x42C6FC0", Offset = "0x42C63C0", VA = "0x1842C6FC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public ECGKCDOMDCF NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4BC9870", Offset = "0x4BC8C70", VA = "0x184BC9870", Slot = "4")]
			get
			{
				return default(ECGKCDOMDCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9780", Offset = "0x4BC8B80", VA = "0x184BC9780")]
		public JBENBPMPPGB(AMDNAFLEPCJ<T> EBAHFMPNPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9680", Offset = "0x4BC8A80", VA = "0x184BC9680", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4327570", Offset = "0x4326970", VA = "0x184327570", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x104C660", Offset = "0x104BA60", VA = "0x18104C660", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct DCMABJDCPFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool BELLALLNDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T FIIKLGCIAGG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int CJFJKMKGDOM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> OLFMFMCMIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private DCMABJDCPFB[] LPLMFGCOHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int PPOFJANHBNG;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int NIMFFCGOFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xC64D20", Offset = "0xC64120", VA = "0x180C64D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xE45CF0", Offset = "0xE450F0", VA = "0x180E45CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E73790", Offset = "0x3E72B90", VA = "0x183E73790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A13A70", Offset = "0x4A12E70", VA = "0x184A13A70")]
	public AMDNAFLEPCJ(int MFDGLHBGGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A13650", Offset = "0x4A12A50", VA = "0x184A13650")]
	public AMDNAFLEPCJ(ECGKCDOMDCF[] NKGBBKPKDNM, bool JOOJBCDDHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4A12860", Offset = "0x4A11C60", VA = "0x184A12860")]
	public int CKOILMPJKFB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4A12C40", Offset = "0x4A12040", VA = "0x184A12C40")]
	private int IGKKIJNNOLE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4A12920", Offset = "0x4A11D20", VA = "0x184A12920", Slot = "6")]
	protected virtual uint GJOJIEPAJLG(uint PNBFDJGGCJP, T FIIKLGCIAGG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4A127A0", Offset = "0x4A11BA0", VA = "0x184A127A0")]
	public bool BCINEMAMEDF(T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4A134B0", Offset = "0x4A128B0", VA = "0x184A134B0")]
	public int POHNBAJGMDC(T FIIKLGCIAGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4A129C0", Offset = "0x4A11DC0", VA = "0x184A129C0")]
	public T IFFONPNJNJH(int KDCAMOIGIMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4A131B0", Offset = "0x4A125B0", VA = "0x184A131B0")]
	public bool PNHHACKNDBJ(T FIIKLGCIAGG, bool KOOAHOPNGHK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4A12F50", Offset = "0x4A12350", VA = "0x184A12F50")]
	public bool PNHHACKNDBJ(T FIIKLGCIAGG, int KDCAMOIGIMA, bool KOOAHOPNGHK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4A12E60", Offset = "0x4A12260", VA = "0x184A12E60")]
	private int JGAJCKNFBLB(int FOGJBEMBBDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4A135B0", Offset = "0x4A129B0", VA = "0x184A135B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4A135B0", Offset = "0x4A129B0", VA = "0x184A135B0", Slot = "4")]
	private IEnumerator<ECGKCDOMDCF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NONJAPDNAMF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> BELFBFACPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> OJJKHBCDMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int PFKBBANNKLK;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x504D180", Offset = "0x504C580", VA = "0x18504D180")]
	public static NONJAPDNAMF<T> GDDCLELACNI(int MFDGLHBGGAA = 0, int PFKBBANNKLK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x504D620", Offset = "0x504CA20", VA = "0x18504D620")]
	public static NONJAPDNAMF<T> MHOLBICBPIB(int MFDGLHBGGAA = 0, int PFKBBANNKLK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x504D900", Offset = "0x504CD00", VA = "0x18504D900")]
	public NONJAPDNAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x504D950", Offset = "0x504CD50", VA = "0x18504D950")]
	public NONJAPDNAMF(int MFDGLHBGGAA, int PFKBBANNKLK = int.MaxValue, bool KDOBAGIANFB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x504D270", Offset = "0x504C670", VA = "0x18504D270")]
	public T GOPOIGEKMOO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x504D440", Offset = "0x504C840", VA = "0x18504D440")]
	public void ICCKCAPBKGG(T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x504D520", Offset = "0x504C920", VA = "0x18504D520")]
	private void LPKBDMGOELB(T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x504CFB0", Offset = "0x504C3B0", VA = "0x18504CFB0")]
	private void BIKCNKHBFJG(T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x504CFF0", Offset = "0x504C3F0", VA = "0x18504CFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x504D710", Offset = "0x504CB10", VA = "0x18504D710")]
	private void NKDNCHCJLDN(IEnumerable<T> EDJBENPLFOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MFICBHKFDEK<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> GCADBJPOPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T KOJBJIACONG;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T MCEMKBFKINB
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4F860F0", Offset = "0x4F854F0", VA = "0x184F860F0")]
	public bool KLGDMCBDBFI(T FIIKLGCIAGG, int CCLELJLNNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4708B00", Offset = "0x4707F00", VA = "0x184708B00")]
	public bool MHIADOPKDEM(int CCLELJLNNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4F86460", Offset = "0x4F85860", VA = "0x184F86460")]
	public T OOOAPJMDOJP(int PFOHLIBCMAG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4F85F00", Offset = "0x4F85300", VA = "0x184F85F00")]
	private bool JIMGOOKPGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4F85EA0", Offset = "0x4F852A0", VA = "0x184F85EA0")]
	public bool HNOOOLJPLPG(int CCLELJLNNPJ, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4708BA0", Offset = "0x4707FA0", VA = "0x184708BA0")]
	public MFICBHKFDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class IJFOCJMLLML<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	protected struct CEOIHEJHHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T HNMCNCHEPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int MCHABLFMAOG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<CEOIHEJHHPG> AHIADGNGGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T LJPDMGAKADM;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3E73790", Offset = "0x3E72B90", VA = "0x183E73790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x49D2CB0", Offset = "0x49D20B0", VA = "0x1849D2CB0")]
	public bool LDBOOCLJOMK(T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x49D2FE0", Offset = "0x49D23E0", VA = "0x1849D2FE0")]
	public void LLICHLCEEGA(T FIIKLGCIAGG, int CCLELJLNNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x49D25D0", Offset = "0x49D19D0", VA = "0x1849D25D0")]
	public bool FBDLIPAFCGJ(T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x49D2940", Offset = "0x49D1D40", VA = "0x1849D2940")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x49D29E0", Offset = "0x49D1DE0", VA = "0x1849D29E0")]
	public T KDKLCAFMGIE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x49D2450", Offset = "0x49D1850", VA = "0x1849D2450")]
	protected void EIHCJJPCCEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x49D3090", Offset = "0x49D2490", VA = "0x1849D3090")]
	public IJFOCJMLLML()
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
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x77DD1B0", Offset = "0x77DC5B0", VA = "0x1877DD1B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x77DD480", Offset = "0x77DC880", VA = "0x1877DD480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x77DD390", Offset = "0x77DC790", VA = "0x1877DD390")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x77DD100", Offset = "0x77DC500", VA = "0x1877DD100")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x77DD3D0", Offset = "0x77DC7D0", VA = "0x1877DD3D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x77DD2E0", Offset = "0x77DC6E0", VA = "0x1877DD2E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x77DD080", Offset = "0x77DC480", VA = "0x1877DD080")]
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
		[Cpp2IlInjected.Address(RVA = "0x54D2CF0", Offset = "0x54D20F0", VA = "0x1854D2CF0", Slot = "4")]
		public virtual T IFJKEAGFJKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class DNLLBGAECKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, INEONENDBGN> CFNPCHANHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly NONJAPDNAMF<INEONENDBGN> BEPLKGFNNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool IBIEHAFJGHP;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public INEONENDBGN OCFDHIKNHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 AJIBNLOEFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x148DBB0", Offset = "0x148CFB0", VA = "0x18148DBB0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xBBDA20", Offset = "0xBBCE20", VA = "0x180BBDA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 OFDEMLMCHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xC07170", Offset = "0xC06570", VA = "0x180C07170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 BKCKKJJAJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x77D9470", Offset = "0x77D8870", VA = "0x1877D9470")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x9933E0", Offset = "0x9927E0", VA = "0x1809933E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int KCIILCOEGBG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x99F890", Offset = "0x99EC90", VA = "0x18099F890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x99F880", Offset = "0x99EC80", VA = "0x18099F880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x77D9F20", Offset = "0x77D9320", VA = "0x1877D9F20")]
	public DNLLBGAECKA(Bounds EHKCFEFNCBL, Vector2[] MAFNMNKNDON, int DBPGCBHBOCF, byte FOGJBEMBBDP, float LOLMEFBABJM = 0f, [Optional] NONJAPDNAMF<INEONENDBGN> BEPLKGFNNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x77D9490", Offset = "0x77D8890", VA = "0x1877D9490")]
	public void JIAEDPIOGHE(Bounds EHKCFEFNCBL, Vector2[] MAFNMNKNDON, int DBPGCBHBOCF, byte FOGJBEMBBDP, float LOLMEFBABJM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x77D9410", Offset = "0x77D8810", VA = "0x1877D9410")]
	public INEONENDBGN HPNICOJLHHE(byte KDCAMOIGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x77D9E50", Offset = "0x77D9250", VA = "0x1877D9E50")]
	public void PIMJCKLBJBC(Vector3 JPKKPDPLAGA, float GKHAGGNKKEK, float IHHHHNEDGHN, List<byte> DFCFDLOEMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x77D8F70", Offset = "0x77D8370", VA = "0x1877D8F70")]
	public void BFMMHIOGEEO(INEONENDBGN.OFFGOOCKFFN LGDNKDNEKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x77D9D70", Offset = "0x77D9170", VA = "0x1877D9D70")]
	public static int MAOJFCKEAEF(Vector2[] MAFNMNKNDON, int DBPGCBHBOCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x77D9B40", Offset = "0x77D8F40", VA = "0x1877D9B40")]
	private INEONENDBGN JPDOOLGAPNC(byte KDCAMOIGIMA, INEONENDBGN.DECCMCHGKDG POCBNEDCGJM, INEONENDBGN PBIFOHNGFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x77D9050", Offset = "0x77D8450", VA = "0x1877D9050")]
	private void GHBKNJILMAJ(INEONENDBGN PBIFOHNGFLL, Vector2[] MAFNMNKNDON, int JHPOLNAFHJA, int ECFFCGOCDNF, int OMMJCGBFMCC, int MLFHCJJJNEB, float LOLMEFBABJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x77D9920", Offset = "0x77D8D20", VA = "0x1877D9920")]
	private void JLEKGDCOEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x77D8F90", Offset = "0x77D8390", VA = "0x1877D8F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x77D8FF0", Offset = "0x77D83F0", VA = "0x1877D8FF0", Slot = "1")]
	~DNLLBGAECKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class INEONENDBGN
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum DECCMCHGKDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum OFFGOOCKFFN
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
	public byte PEOBHBKAJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 PACPNDLKHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 FONFMMJKOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 JOKIOPFACBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 BMPELJLOFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public DECCMCHGKDG DLEPHAMIPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public INEONENDBGN DHHOIDHGNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<INEONENDBGN> JEEMKLGLOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool BJACMPNPIOB;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x77DC840", Offset = "0x77DBC40", VA = "0x1877DC840")]
	public INEONENDBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x77DC3B0", Offset = "0x77DB7B0", VA = "0x1877DC3B0")]
	public void AFKMCGFGABH(INEONENDBGN KIGPNOGAENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	public void BFMMHIOGEEO(int GIBEIEPIMFO, OFFGOOCKFFN LGDNKDNEKGD, int FHNCPADKJBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x77DC5E0", Offset = "0x77DB9E0", VA = "0x1877DC5E0")]
	public void PIMJCKLBJBC(List<byte> DFCFDLOEMOE, Vector3 JPKKPDPLAGA, float GKHAGGNKKEK, float IHHHHNEDGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x77DC4F0", Offset = "0x77DB8F0", VA = "0x1877DC4F0")]
	public bool ECGGHCGDHHP(Vector3 KBMNNOPIBPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x77DC520", Offset = "0x77DB920", VA = "0x1877DC520")]
	public bool GINEFPNJCAF(Vector3 KBMNNOPIBPC, float GHGHBOKKEJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x77DC550", Offset = "0x77DB950", VA = "0x1877DC550")]
	public void MBHBIOMKKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface KNEIPKBDOKO
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache PEEAEKNDJII
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
		public struct AEFDDGNJMJA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> JMHKEMEJOPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool NDJOOHLJCBI;

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1681620", Offset = "0x1680A20", VA = "0x181681620")]
			public AEFDDGNJMJA(List<Component> JMHKEMEJOPH, bool NDJOOHLJCBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x48D6FA0", Offset = "0x48D63A0", VA = "0x1848D6FA0")]
			public LIJIKPKDFBJ<T> NHFIHKFCIDL()
			{
				return default(LIJIKPKDFBJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x48D7000", Offset = "0x48D6400", VA = "0x1848D7000", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x48D7000", Offset = "0x48D6400", VA = "0x1848D7000", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct LIJIKPKDFBJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> JMHKEMEJOPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool NDJOOHLJCBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int KDCAMOIGIMA;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T NDNCOCJHCAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x4D89230", Offset = "0x4D88630", VA = "0x184D89230", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x4D891C0", Offset = "0x4D885C0", VA = "0x184D891C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4D89200", Offset = "0x4D88600", VA = "0x184D89200")]
			public LIJIKPKDFBJ(List<Component> JMHKEMEJOPH, bool NDJOOHLJCBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x4D89100", Offset = "0x4D88500", VA = "0x184D89100", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x4D89110", Offset = "0x4D88510", VA = "0x184D89110", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x43156F0", Offset = "0x4314AF0", VA = "0x1843156F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x77DEE70", Offset = "0x77DE270", VA = "0x1877DEE70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x77DEC70", Offset = "0x77DE070", VA = "0x1877DEC70")]
		private void MBHBIOMKKEG(GameObject BJEKBBADBGH, bool HEGINIGEJIB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x77DEBE0", Offset = "0x77DDFE0", VA = "0x1877DEBE0")]
		public static void MBHBIOMKKEG(GameObject BJEKBBADBGH, ToolHierarchyCache LPEBEIIGFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x77DE760", Offset = "0x77DDB60", VA = "0x1877DE760")]
		public void AKGOFJAKECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3973F20", Offset = "0x3973320", VA = "0x183973F20")]
		public void EJODECMLDHB<T>(Action<T> AKLHLNJOCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3973E80", Offset = "0x3973280", VA = "0x183973E80")]
		public T BCNBMACKHEE<T>(bool NDJOOHLJCBI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3974160", Offset = "0x3973560", VA = "0x183974160")]
		public AEFDDGNJMJA<T> LJBMOFMPDBL<T>(bool NDJOOHLJCBI = false) where T : class
		{
			return default(AEFDDGNJMJA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x77DE860", Offset = "0x77DDC60", VA = "0x1877DE860")]
		public List<Component> HDCLFDOLNEK(Type MAIGGPEPIHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x77DE770", Offset = "0x77DDB70", VA = "0x1877DE770", Slot = "4")]
		public bool Equals(ToolHierarchyCache JFJPEDLJOKC, ToolHierarchyCache MJINJIJLGDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x77DE7F0", Offset = "0x77DDBF0", VA = "0x1877DE7F0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HAPOBHMBDHP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class JJLFEGMEGGB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int MFDGLHBGGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int BMPCBHFNLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> OBLBKNNLCEP;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x48744A0", Offset = "0x48738A0", VA = "0x1848744A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T FOBEBPIMKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4BF0740", Offset = "0x4BEFB40", VA = "0x184BF0740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T CGBJPIOKEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4BF05E0", Offset = "0x4BEF9E0", VA = "0x184BF05E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T IPMODJOJLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4BF00B0", Offset = "0x4BEF4B0", VA = "0x184BF00B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x4BF0830", Offset = "0x4BEFC30", VA = "0x184BF0830")]
	public JJLFEGMEGGB(int MFDGLHBGGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4BF02B0", Offset = "0x4BEF6B0", VA = "0x184BF02B0")]
	public void LLICHLCEEGA(T NDLFPBNJODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4BF01F0", Offset = "0x4BEF5F0", VA = "0x184BF01F0")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4BEFF50", Offset = "0x4BEF350", VA = "0x184BEFF50")]
	public void ACACCLFHDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4BF0250", Offset = "0x4BEF650", VA = "0x184BF0250")]
	public void IEBFKDBBMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4BF0150", Offset = "0x4BEF550", VA = "0x184BF0150")]
	public void DGDLKKIGKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4BF0160", Offset = "0x4BEF560", VA = "0x184BF0160")]
	public List<T> ENGEKOPDIAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class APCFHKHDALJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct GENGPCFIDCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int MCHABLFMAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T HNMCNCHEPGK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, GENGPCFIDCC> GCADBJPOPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> DGPOJJLGJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T KOJBJIACONG;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T MCEMKBFKINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xC6CCA0", Offset = "0xC6C0A0", VA = "0x180C6CCA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4A23710", Offset = "0x4A22B10", VA = "0x184A23710", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool MEAMJNHCOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4A23680", Offset = "0x4A22A80", VA = "0x184A23680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object LPLOOFLKMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x991DA0", Offset = "0x9911A0", VA = "0x180991DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4A26AB0", Offset = "0x4A25EB0", VA = "0x184A26AB0")]
	public bool KLGDMCBDBFI(T FIIKLGCIAGG, object HEJFDMJNIGB, int CCLELJLNNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4A27030", Offset = "0x4A26430", VA = "0x184A27030")]
	public bool MHIADOPKDEM(object HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4A23A00", Offset = "0x4A22E00", VA = "0x184A23A00")]
	public bool HNOOOLJPLPG(object HEJFDMJNIGB, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4A23750", Offset = "0x4A22B50", VA = "0x184A23750")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4A24860", Offset = "0x4A23C60", VA = "0x184A24860")]
	private bool JIMGOOKPGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4A27120", Offset = "0x4A26520", VA = "0x184A27120")]
	public APCFHKHDALJ()
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
