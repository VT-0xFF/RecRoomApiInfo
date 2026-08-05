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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69D9AF0", Offset = "0x69D80F0", VA = "0x1869D9AF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EEJHKNAPMCO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15163B0", Offset = "0x15149B0", VA = "0x1815163B0")]
	public EEJHKNAPMCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, MAGJMGHKFJB, NKDJHGEIMFA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x868230", Offset = "0x866830", VA = "0x180868230", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JEEDPHFPHKM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8F7720", Offset = "0x8F5D20", VA = "0x1808F7720")]
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
		[Cpp2IlInjected.Address(RVA = "0x69DAFA0", Offset = "0x69D95A0", VA = "0x1869DAFA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69DAF60", Offset = "0x69D9560", VA = "0x1869DAF60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69DAFE0", Offset = "0x69D95E0", VA = "0x1869DAFE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69DB190", Offset = "0x69D9790", VA = "0x1869DB190")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x69DB100", Offset = "0x69D9700", VA = "0x1869DB100")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F7710", Offset = "0x8F5D10", VA = "0x1808F7710")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F76D0", Offset = "0x8F5CD0", VA = "0x1808F76D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69DAF20", Offset = "0x69D9520", VA = "0x1869DAF20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69DB070", Offset = "0x69D9670", VA = "0x1869DB070")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69DA990", Offset = "0x69D8F90", VA = "0x1869DA990")]
	public void CopyBounds(SavedExtents BHFGHGMPKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69DAE70", Offset = "0x69D9470", VA = "0x1869DAE70")]
	public void SetLocalSpaceBounds(Bounds FNKMKDDKDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBE1890", Offset = "0xBDFE90", VA = "0x180BE1890")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69DAE60", Offset = "0x69D9460", VA = "0x1869DAE60")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69DA9C0", Offset = "0x69D8FC0", VA = "0x1869DA9C0")]
	private void DGDHHJEOIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69DAC40", Offset = "0x69D9240", VA = "0x1869DAC40")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69DA320", Offset = "0x69D8920", VA = "0x1869DA320")]
	public static void CalculateLocalBoundsFor(GameObject FNAHDAKHMJN, [Out] Bounds FNKMKDDKDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69DAB80", Offset = "0x69D9180", VA = "0x1869DAB80")]
	private static void HPOCDBIKAJJ(Bounds CGBLKAAFCDI, Color NAHNDCNFAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69DAE90", Offset = "0x69D9490", VA = "0x1869DAE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x101B970", Offset = "0x1019F70", VA = "0x18101B970")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x49F3230", Offset = "0x49F1830", VA = "0x1849F3230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "4")]
	public virtual void GADJFGEOOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
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
	[SerializeField]
	[EEJHKNAPMCO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49F2D60", Offset = "0x49F1360", VA = "0x1849F2D60", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49F1410", Offset = "0x49EFA10", VA = "0x1849F1410", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49F3120", Offset = "0x49F1720", VA = "0x1849F3120")]
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
	private sealed class LGFMELLAAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public LGFMELLAAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x42CFD40", Offset = "0x42CE340", VA = "0x1842CFD40")]
		internal int MBPMLLOHLIA(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[EEJHKNAPMCO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x389B530", Offset = "0x3899B30", VA = "0x18389B530", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x389B590", Offset = "0x3899B90", VA = "0x18389B590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x389B400", Offset = "0x3899A00", VA = "0x18389B400", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey IBBDLGCDELM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x389B4C0", Offset = "0x3899AC0", VA = "0x18389B4C0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x389B2A0", Offset = "0x38998A0", VA = "0x18389B2A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x389AF40", Offset = "0x3899540", VA = "0x18389AF40", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x389A300", Offset = "0x3898900", VA = "0x18389A300", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x389A1C0", Offset = "0x38987C0", VA = "0x18389A1C0", Slot = "14")]
	protected virtual string BIFFHPCIGEL(TKeyVal ILNELDEEBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x389A1F0", Offset = "0x38987F0", VA = "0x18389A1F0", Slot = "4")]
	public bool ContainsKey(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x389B110", Offset = "0x3899710", VA = "0x18389B110", Slot = "5")]
	public bool TryGetValue(TKey IBBDLGCDELM, [Out] TVal DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x389A250", Offset = "0x3898850", VA = "0x18389A250", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x389A250", Offset = "0x3898850", VA = "0x18389A250", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x389B170", Offset = "0x3899770", VA = "0x18389B170")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IAPEBLHIIAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class KCLKICPHLPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float EKGLKBMMNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T FJLALGMPANI;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public KCLKICPHLPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LINCNPHAAGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public LINCNPHAAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x42DE620", Offset = "0x42DCC20", VA = "0x1842DE620")]
		internal bool KFLIEMPFDND(KCLKICPHLPE sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float NBDDMFHHIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float JCHJKCOJAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<KCLKICPHLPE> BNLOMEDIACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private OCDMEAEINPK<KCLKICPHLPE> JOPLGJNFGAE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int OKBDFEAJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E4ACB0", Offset = "0x3E492B0", VA = "0x183E4ACB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4B9F0", Offset = "0x3E49FF0", VA = "0x183E4B9F0")]
	public IAPEBLHIIAN(float PMALGGOLDDF, float LJEGALHNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E4B800", Offset = "0x3E49E00", VA = "0x183E4B800")]
	public bool NKCFDLHHGHM(float BNGEJPOFIKJ, T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E4B0C0", Offset = "0x3E496C0", VA = "0x183E4B0C0")]
	public IEnumerable<T> KJFOCMLMLBN(float BNGEJPOFIKJ, [Optional] float? AHPLLFHLELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AB80", Offset = "0x3E49180", VA = "0x183E4AB80")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E4B460", Offset = "0x3E49A60", VA = "0x183E4B460")]
	private void LKLHCFEJADE(float BNGEJPOFIKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class NCOJOAEIPFL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct JMGAIKMBODK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T FJLALGMPANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float IJLDJCOHPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float JIIDPKDPDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> EJBNJPMKCAL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int BIDLHLDGCOC = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private JMGAIKMBODK[] FAJBEEIFFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int LBBKNECLKEI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float AFBBIPHCDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9D2E90", Offset = "0x9D1490", VA = "0x1809D2E90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9E3E60", Offset = "0x9E2460", VA = "0x1809E3E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x455C810", Offset = "0x455AE10", VA = "0x18455C810")]
	public NCOJOAEIPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x455C850", Offset = "0x455AE50", VA = "0x18455C850")]
	public NCOJOAEIPFL(int LPKLLJKOBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x455C190", Offset = "0x455A790", VA = "0x18455C190")]
	public void LHEPNGLDBLI(float BNGEJPOFIKJ, T DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x455B6D0", Offset = "0x4559CD0", VA = "0x18455B6D0")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x455B8E0", Offset = "0x4559EE0", VA = "0x18455B8E0")]
	public bool HGFFGAHCMAP(float GLKMLBFMKIJ, float MNMOKCENPGJ, [Out] T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x455C3B0", Offset = "0x455A9B0", VA = "0x18455C3B0")]
	public bool PAOIHKBDMOH(float GLKMLBFMKIJ, float MNMOKCENPGJ, [Out] T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x455BE10", Offset = "0x455A410", VA = "0x18455BE10")]
	public void JDMHJHABNPO(float GLKMLBFMKIJ, float MNMOKCENPGJ, List<T> JDFOAHNNFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x455B8B0", Offset = "0x4559EB0", VA = "0x18455B8B0")]
	private int ECELAOIOMMD(int DKJDIJFIFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x455C140", Offset = "0x455A740", VA = "0x18455C140")]
	private void JPKDCPAILLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FMCCCMKGIMH();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T ELBJGPEEFCJ(T DMNGPNKHPKF, float FCNFHCDDANP);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T MDKNEDCCKDJ(T OIMGCNDKIAD, T LMBIFCGLAFC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HNAPOCOPFEM(T OIMGCNDKIAD, T LMBIFCGLAFC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DHHHGOAOBID : NCOJOAEIPFL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x876D20", Offset = "0x875320", VA = "0x180876D20", Slot = "4")]
	protected override Vector3 FMCCCMKGIMH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69D82B0", Offset = "0x69D68B0", VA = "0x1869D82B0", Slot = "5")]
	protected override Vector3 ELBJGPEEFCJ(Vector3 DMNGPNKHPKF, float FCNFHCDDANP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69D8370", Offset = "0x69D6970", VA = "0x1869D8370", Slot = "6")]
	protected override Vector3 MDKNEDCCKDJ(Vector3 OIMGCNDKIAD, Vector3 LMBIFCGLAFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69D82F0", Offset = "0x69D68F0", VA = "0x1869D82F0", Slot = "7")]
	protected override Vector3 HNAPOCOPFEM(Vector3 OIMGCNDKIAD, Vector3 LMBIFCGLAFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69D83C0", Offset = "0x69D69C0", VA = "0x1869D83C0")]
	public DHHHGOAOBID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JGJKANEIBPA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF50A0", Offset = "0x2BF36A0", VA = "0x182BF50A0")]
	public static DAENNPGKFEM<T1, T2> BBHPEKFPBBP<T1, T2>(T1 HANKCKPMKKD, T2 DMLGBEJBOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5140", Offset = "0x2BF3740", VA = "0x182BF5140")]
	public static KFLEEFHNAHO<T1, T2, T3> BBHPEKFPBBP<T1, T2, T3>(T1 HANKCKPMKKD, T2 DMLGBEJBOGB, T3 KGGFDLBBAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x452A3A0", Offset = "0x45289A0", VA = "0x18452A3A0")]
	internal static int GHACDHDOEGK(int GPHOAOKKLDM, int GFBLENPIFJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D81A40", Offset = "0x5D80040", VA = "0x185D81A40")]
	internal static int GHACDHDOEGK(int GPHOAOKKLDM, int GFBLENPIFJO, int OCHPLMCDNOO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DAENNPGKFEM<T1, T2> : IComparable<DAENNPGKFEM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 HLCFBJECBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 PMFFBFFNBNM;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x58A7E60", Offset = "0x58A6460", VA = "0x1858A7E60")]
	public DAENNPGKFEM(T1 HANKCKPMKKD, T2 DMLGBEJBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x58A62E0", Offset = "0x58A48E0", VA = "0x1858A62E0", Slot = "4")]
	public int CompareTo(DAENNPGKFEM<T1, T2> BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x58A6B40", Offset = "0x58A5140", VA = "0x1858A6B40", Slot = "0")]
	public override bool Equals(object BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x58A70C0", Offset = "0x58A56C0", VA = "0x1858A70C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x58A7A10", Offset = "0x58A6010", VA = "0x1858A7A10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KFLEEFHNAHO<T1, T2, T3> : IComparable<KFLEEFHNAHO<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 HLCFBJECBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 PMFFBFFNBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 LNBMBEKMADF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x418E040", Offset = "0x418C640", VA = "0x18418E040")]
	public KFLEEFHNAHO(T1 HANKCKPMKKD, T2 DMLGBEJBOGB, T3 KGGFDLBBAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x418D6D0", Offset = "0x418BCD0", VA = "0x18418D6D0", Slot = "4")]
	public int CompareTo(KFLEEFHNAHO<T1, T2, T3> BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x418DA90", Offset = "0x418C090", VA = "0x18418DA90", Slot = "0")]
	public override bool Equals(object BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x418DCD0", Offset = "0x418C2D0", VA = "0x18418DCD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x418DD70", Offset = "0x418C370", VA = "0x18418DD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T FJLALGMPANI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x23529A0", Offset = "0x2350FA0", VA = "0x1823529A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x23526B0", Offset = "0x2350CB0", VA = "0x1823526B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float NJAFCOMEFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F7670", Offset = "0x8F5C70", VA = "0x1808F7670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D830", Offset = "0x4C3BE30", VA = "0x184C3D830")]
	public T PHKNOOKNPDG(float FCNFHCDDANP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D420", Offset = "0x4C3BA20", VA = "0x184C3D420")]
	public T CFAEOIMOLOJ(float FCNFHCDDANP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NPGDNNHHBLK(T OIMGCNDKIAD, T LMBIFCGLAFC, float FCNFHCDDANP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69D8490", Offset = "0x69D6A90", VA = "0x1869D8490", Slot = "4")]
	protected override float NPGDNNHHBLK(float OIMGCNDKIAD, float LMBIFCGLAFC, float FCNFHCDDANP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69D84D0", Offset = "0x69D6AD0", VA = "0x1869D84D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xEA89B0", Offset = "0xEA6FB0", VA = "0x180EA89B0", Slot = "4")]
	protected override Vector3 NPGDNNHHBLK(Vector3 OIMGCNDKIAD, Vector3 LMBIFCGLAFC, float FCNFHCDDANP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69DBFA0", Offset = "0x69DA5A0", VA = "0x1869DBFA0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69D81B0", Offset = "0x69D67B0", VA = "0x1869D81B0", Slot = "4")]
	protected override Color NPGDNNHHBLK(Color OIMGCNDKIAD, Color LMBIFCGLAFC, float FCNFHCDDANP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69D8270", Offset = "0x69D6870", VA = "0x1869D8270")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LKCAONIIHPK : EIOACLLPMOC<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69D9940", Offset = "0x69D7F40", VA = "0x1869D9940")]
	public LKCAONIIHPK(int PLGOIBDCNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x69D98D0", Offset = "0x69D7ED0", VA = "0x1869D98D0", Slot = "6")]
	protected override uint FKIGLJCEHPL(uint JEEDPHFPHKM, string DMNGPNKHPKF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HOJFBDNBFEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable CFNNMJAMDBB;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public HOJFBDNBFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BMFAKFHPJLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PEAKCEKKMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int IDLLHHPNKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int DEJGFNHLDAJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x452C600", Offset = "0x452AC00", VA = "0x18452C600")]
	private BMFAKFHPJLI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HIBFAMBABKH, int JIDMHBBMNEJ, int OJCFKEIELKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4F2FF50", Offset = "0x4F2E550", VA = "0x184F2FF50")]
	public static BMFAKFHPJLI<T> ENFOKLPNHAF()
	{
		return default(BMFAKFHPJLI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4F2E930", Offset = "0x4F2CF30", VA = "0x184F2E930")]
	public (int, int, Task<T>) AKGOMIIDKGE(int FFHBHOMFFND, [Optional] CancellationToken FIMAIPEFOAM, double HAGKGIBCOBL = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4F30060", Offset = "0x4F2E660", VA = "0x184F30060")]
	public void HAKBFDIBDCH(int FFHBHOMFFND, int OJCFKEIELKK, [In] T IAFCFGOKEAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NJAJCBAJKNN
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69D9A20", Offset = "0x69D8020", VA = "0x1869D9A20")]
	public static BMFAKFHPJLI<COKMANPFJNC> ENFOKLPNHAF()
	{
		return default(BMFAKFHPJLI<COKMANPFJNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69D9A70", Offset = "0x69D8070", VA = "0x1869D9A70")]
	public static void HAKBFDIBDCH([In] this BMFAKFHPJLI<COKMANPFJNC> HLIDMKMINHN, int FFHBHOMFFND, int OJCFKEIELKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class MDCAOFOANPI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> HLKDILFCCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> BGDICEKKLCE;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x35D58A0", Offset = "0x35D3EA0", VA = "0x1835D58A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool IJMBFBLHEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> MHEOEAKGEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x385D9E0", Offset = "0x385BFE0", VA = "0x18385D9E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> ONHPNGNLGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x385DBE0", Offset = "0x385C1E0", VA = "0x18385DBE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x44BD230", Offset = "0x44BB830", VA = "0x1844BD230", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x44BD2E0", Offset = "0x44BB8E0", VA = "0x1844BD2E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x44BCB20", Offset = "0x44BB120", VA = "0x1844BCB20")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44BC860", Offset = "0x44BAE60", VA = "0x1844BC860", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x44BD000", Offset = "0x44BB600", VA = "0x1844BD000", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x44BC580", Offset = "0x44BAB80", VA = "0x1844BC580", Slot = "9")]
	public void Add(TKey IBBDLGCDELM, TVal DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x44BC530", Offset = "0x44BAB30", VA = "0x1844BC530", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x385B970", Offset = "0x3859F70", VA = "0x18385B970", Slot = "8")]
	public bool ContainsKey(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x44BC910", Offset = "0x44BAF10", VA = "0x1844BC910", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x44BCF40", Offset = "0x44BB540", VA = "0x1844BCF40", Slot = "10")]
	public bool Remove(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x44BCF80", Offset = "0x44BB580", VA = "0x1844BCF80", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x44BD0A0", Offset = "0x44BB6A0", VA = "0x1844BD0A0", Slot = "11")]
	public bool TryGetValue(TKey IBBDLGCDELM, [Out] TVal DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x44BCA20", Offset = "0x44BB020", VA = "0x1844BCA20", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x44BC990", Offset = "0x44BAF90", VA = "0x1844BC990", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FAJBEEIFFCK, int FLPMGGGFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x44BC480", Offset = "0x44BAA80", VA = "0x1844BC480")]
	public bool APLEJEFPFAB(TVal IBBDLGCDELM, [Out] TKey DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x44BCB80", Offset = "0x44BB180", VA = "0x1844BCB80")]
	private void NPFLKJCJLBA(TKey IBBDLGCDELM, TVal KPJDKHEOHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x44BCD60", Offset = "0x44BB360", VA = "0x1844BCD60")]
	private void OOJAAJCMLJI(TKey IBBDLGCDELM, TVal KPJDKHEOHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x44BC610", Offset = "0x44BAC10", VA = "0x1844BC610")]
	private bool BPDMKMHDOMH(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x44BD100", Offset = "0x44BB700", VA = "0x1844BD100")]
	public MDCAOFOANPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class PFMBFIJENLA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private PFMBFIJENLA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x38E80E0", Offset = "0x38E66E0", VA = "0x1838E80E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x38EF2A0", Offset = "0x38ED8A0", VA = "0x1838EF2A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x38EFF90", Offset = "0x38EE590", VA = "0x1838EFF90")]
		public Enumerator(PFMBFIJENLA<T> JDFOAHNNFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38ED2F0", Offset = "0x38EB8F0", VA = "0x1838ED2F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x38EE340", Offset = "0x38EC940", VA = "0x1838EE340", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38ECCE0", Offset = "0x38EB2E0", VA = "0x1838ECCE0")]
		private void ICOGHGENFMH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] BHDAJGDNINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int CMKHMGALFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int OCNGKIJHOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int CICFELNCFMD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x47B7350", Offset = "0x47B5950", VA = "0x1847B7350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x47B8BA0", Offset = "0x47B71A0", VA = "0x1847B8BA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x47B7E40", Offset = "0x47B6440", VA = "0x1847B7E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x47B9090", Offset = "0x47B7690", VA = "0x1847B9090")]
	public PFMBFIJENLA(int PLGOIBDCNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x47B8430", Offset = "0x47B6A30", VA = "0x1847B8430")]
	public void LHEPNGLDBLI(T FCNFHCDDANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x47B7BF0", Offset = "0x47B61F0", VA = "0x1847B7BF0")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x47B7390", Offset = "0x47B5990", VA = "0x1847B7390")]
	public void BEIEIDJKLON(int BMKFLHFENBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x47B7470", Offset = "0x47B5A70", VA = "0x1847B7470")]
	public void DGCLHGFMGCI(T[] FAJBEEIFFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x47B7CD0", Offset = "0x47B62D0", VA = "0x1847B7CD0")]
	public Enumerator GGGADAADMEJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x47B8F20", Offset = "0x47B7520", VA = "0x1847B8F20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x47B8F20", Offset = "0x47B7520", VA = "0x1847B8F20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x47B8920", Offset = "0x47B6F20", VA = "0x1847B8920")]
	private int LMNHKMJDBGI(int PDMMEDBMFPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x47B7320", Offset = "0x47B5920", VA = "0x1847B7320")]
	private int AAPCAFAGGNN(int PDMMEDBMFPP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MFGONABOJEJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> GMEOJFKAJLO(TRequest EPDDNPCGMCI, CancellationToken FIMAIPEFOAM);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum MELFNOOCJAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AJLJMKHIENJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float LJOBEDGEJLG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan OAICDKGPNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int CLHJEHBIDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public MELFNOOCJAI IJMAILMOBGF;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly AJLJMKHIENJ ABMFDACMOIG;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float DKNLLHPALFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x3D6E530", Offset = "0x3D6CB30", VA = "0x183D6E530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan KKFBLLGGCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E760", Offset = "0x3D6CD60", VA = "0x183D6E760")]
		public AJLJMKHIENJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct MOHFDPCGJGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest EPDDNPCGMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken FIMAIPEFOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> GNOPBNMOHBK;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x44F8750", Offset = "0x44F6D50", VA = "0x1844F8750")]
		public MOHFDPCGJGB(TRequest EPDDNPCGMCI, TaskCompletionSource<TResult> GNOPBNMOHBK, CancellationToken FIMAIPEFOAM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct NNKPKMHKKDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public MFGONABOJEJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x45DAFB0", Offset = "0x45D95B0", VA = "0x1845DAFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x45DB480", Offset = "0x45D9A80", VA = "0x1845DB480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NMHFKPBGADL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public MFGONABOJEJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private MOHFDPCGJGB <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x45D6480", Offset = "0x45D4A80", VA = "0x1845D6480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x45D7780", Offset = "0x45D5D80", VA = "0x1845D7780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource DHIEKGGNGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<MOHFDPCGJGB> CFFAPCFFJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AJLJMKHIENJ DHLHJAFPDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly GMEOJFKAJLO EPJMCHAECCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task JIOLAFAIIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int BMBMMDBFKMA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x44C7AD0", Offset = "0x44C60D0", VA = "0x1844C7AD0")]
	public MFGONABOJEJ(GMEOJFKAJLO EPJMCHAECCP, [Optional] AJLJMKHIENJ DHLHJAFPDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x44C6510", Offset = "0x44C4B10", VA = "0x1844C6510")]
	public Task<TResult> DJEHAOLMMOA(TRequest EPDDNPCGMCI, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x44C6880", Offset = "0x44C4E80", VA = "0x1844C6880")]
	private void FBAFIAIFCHI(MOHFDPCGJGB JKJHFBJAPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x44C5DD0", Offset = "0x44C43D0", VA = "0x1844C5DD0")]
	[AsyncStateMachine(typeof(MFGONABOJEJ<, >.NNKPKMHKKDH))]
	private Task DCBOHEKDDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x44C7030", Offset = "0x44C5630", VA = "0x1844C7030")]
	private MOHFDPCGJGB MJPMHPOAMPP()
	{
		return default(MOHFDPCGJGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x44C6F40", Offset = "0x44C5540", VA = "0x1844C6F40")]
	[AsyncStateMachine(typeof(MFGONABOJEJ<, >.NMHFKPBGADL))]
	private Task LNDHOAOLAFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x44C6C40", Offset = "0x44C5240", VA = "0x1844C6C40")]
	private void HAHBPMPAJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x44C6750", Offset = "0x44C4D50", VA = "0x1844C6750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class PKGPEHJKMCC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> DEPHDEBCNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> HHLGEGFINMO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x35D58A0", Offset = "0x35D3EA0", VA = "0x1835D58A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IJMBFBLHEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A0FF30", Offset = "0x2A0E530", VA = "0x182A0FF30", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x47F98F0", Offset = "0x47F7EF0", VA = "0x1847F98F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D0C0", Offset = "0x3C6B6C0", VA = "0x183C6D0C0", Slot = "11")]
	public void Add(T JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x47F8FB0", Offset = "0x47F75B0", VA = "0x1847F8FB0")]
	public bool FJEHGINIDKI(T JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47F9620", Offset = "0x47F7C20", VA = "0x1847F9620", Slot = "15")]
	public bool Remove(T JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3E89040", Offset = "0x3E87640", VA = "0x183E89040", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C41590", Offset = "0x3C3FB90", VA = "0x183C41590", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x47F8D30", Offset = "0x47F7330", VA = "0x1847F8D30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x47F8DE0", Offset = "0x47F73E0", VA = "0x1847F8DE0", Slot = "13")]
	public bool Contains(T JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x47F8E40", Offset = "0x47F7440", VA = "0x1847F8E40", Slot = "14")]
	public void CopyTo(T[] FAJBEEIFFCK, int FLPMGGGFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x428DA90", Offset = "0x428C090", VA = "0x18428DA90", Slot = "6")]
	public int IndexOf(T JAGONPFFNPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x47F90C0", Offset = "0x47F76C0", VA = "0x1847F90C0", Slot = "7")]
	public void Insert(int PDMMEDBMFPP, T JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x47F94C0", Offset = "0x47F7AC0", VA = "0x1847F94C0", Slot = "8")]
	public void RemoveAt(int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x47F97C0", Offset = "0x47F7DC0", VA = "0x1847F97C0")]
	public PKGPEHJKMCC()
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
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x21E16B0", Offset = "0x21DFCB0", VA = "0x1821E16B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x69DB530", Offset = "0x69D9B30", VA = "0x1869DB530")]
		public SerializedGuid([In] Guid IJNLNGBKEAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69DB400", Offset = "0x69D9A00", VA = "0x1869DB400")]
		public static SerializedGuid OEAJCJPAINP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x69DB390", Offset = "0x69D9990", VA = "0x1869DB390")]
		public static SerializedGuid LHFNLJCFEHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x69DB330", Offset = "0x69D9930", VA = "0x1869DB330")]
		public bool HIFFGJEKBHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x69DB500", Offset = "0x69D9B00", VA = "0x1869DB500", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x69DB480", Offset = "0x69D9A80", VA = "0x1869DB480", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69DB250", Offset = "0x69D9850", VA = "0x1869DB250", Slot = "7")]
		public bool Equals(SerializedGuid BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x69DB290", Offset = "0x69D9890", VA = "0x1869DB290", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x69DB320", Offset = "0x69D9920", VA = "0x1869DB320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x69DB220", Offset = "0x69D9820", VA = "0x1869DB220", Slot = "6")]
		public int CompareTo(SerializedGuid BHFGHGMPKOJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FJANKFAMMGP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type GFHHDPIOHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string ELCAAHEELLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool PMBLHDHLNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool IDBGDIPBAHN;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69D8420", Offset = "0x69D6A20", VA = "0x1869D8420")]
	public FJANKFAMMGP(Type DBHCEMGEFCE, string DIDHHIMNHHI, bool JPIFMJLDGCO = false, bool AMPBAOLCEJG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KEFLMHFIOFB<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct FLDEHOGEGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long JAAOMGONMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long DJMDJIFHKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int NJKGEFNPFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int PHMJJOMMHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool OPCHGFNIKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string MFJAFALOOJF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C38630", Offset = "0x3C36C30", VA = "0x183C38630")]
		public FLDEHOGEGMO(long JAAOMGONMPB, int NJKGEFNPFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C38600", Offset = "0x3C36C00", VA = "0x183C38600")]
		public FLDEHOGEGMO(long JAAOMGONMPB, long DJMDJIFHKOJ, int NJKGEFNPFBB, int PHMJJOMMHAE, bool OPCHGFNIKDF, string MFJAFALOOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C38550", Offset = "0x3C36B50", VA = "0x183C38550")]
		public int LGLIHAHDFIE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C38490", Offset = "0x3C36A90", VA = "0x183C38490")]
		public int FEKCAMPIMNM(int PJKGBGMIALO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C385A0", Offset = "0x3C36BA0", VA = "0x183C385A0")]
		public double LLLHHGJKGLA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C384B0", Offset = "0x3C36AB0", VA = "0x183C384B0")]
		public FLDEHOGEGMO GBPDDJDCJOH(long DJMDJIFHKOJ, int PHMJJOMMHAE)
		{
			return default(FLDEHOGEGMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class JJGFAMJGLBE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct NDJANMHAMMG<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public JJGFAMJGLBE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<JJGFAMJGLBE, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private JJGFAMJGLBE <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x455DBE0", Offset = "0x455C1E0", VA = "0x18455DBE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4559370", Offset = "0x4557970", VA = "0x184559370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey EHBGNDCNEJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly KEFLMHFIOFB<TKey> LAEFIIJCIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly PBGLEKOCCEM APPJEAMJBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<JJGFAMJGLBE> DOMCMCPPHEI;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string DKBPELCIKKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x40926B0", Offset = "0x4090CB0", VA = "0x1840926B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<JJGFAMJGLBE> ANLODCJNAEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x4092200", Offset = "0x4090800", VA = "0x184092200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public FLDEHOGEGMO ANMCHCMBFJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4092690", Offset = "0x4090C90", VA = "0x184092690")]
			[CompilerGenerated]
			get
			{
				return default(FLDEHOGEGMO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4092400", Offset = "0x4090A00", VA = "0x184092400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4092710", Offset = "0x4090D10", VA = "0x184092710")]
		internal JJGFAMJGLBE(KEFLMHFIOFB<TKey> LAEFIIJCIDG, TKey IBBDLGCDELM, PBGLEKOCCEM APPJEAMJBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4092240", Offset = "0x4090840", VA = "0x184092240")]
		public JJGFAMJGLBE CKJELCPADID(TKey IBBDLGCDELM, [Optional] PBGLEKOCCEM? CAIOEMPHEDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9470", Offset = "0x2AD7A70", VA = "0x182AD9470")]
		[AsyncStateMachine(typeof(NDJANMHAMMG<>))]
		public Task<T> JMLCKMOFAAE<T>(TKey IBBDLGCDELM, Func<JJGFAMJGLBE, Task<T>> ILHEMCJEFIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4092430", Offset = "0x4090A30", VA = "0x184092430", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CCLNDKALPME : IEnumerable<(TKey, List<TKey>, FLDEHOGEGMO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FLDEHOGEGMO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, FLDEHOGEGMO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KEFLMHFIOFB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, FLDEHOGEGMO timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, FLDEHOGEGMO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21DF220", Offset = "0x21DD820", VA = "0x1821DF220", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FLDEHOGEGMO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x528FB10", Offset = "0x528E110", VA = "0x18528FB10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21DF310", Offset = "0x21DD910", VA = "0x1821DF310")]
		[DebuggerHidden]
		public CCLNDKALPME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x38769E0", Offset = "0x3874FE0", VA = "0x1838769E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x528F630", Offset = "0x528DC30", VA = "0x18528F630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x528F5E0", Offset = "0x528DBE0", VA = "0x18528F5E0")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x528FAC0", Offset = "0x528E0C0", VA = "0x18528FAC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x528F9E0", Offset = "0x528DFE0", VA = "0x18528F9E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FLDEHOGEGMO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3B01F50", Offset = "0x3B00550", VA = "0x183B01F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LPKGDPKOAFO : IEnumerable<(TKey, List<TKey>, FLDEHOGEGMO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FLDEHOGEGMO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, FLDEHOGEGMO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private JJGFAMJGLBE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public JJGFAMJGLBE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KEFLMHFIOFB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<JJGFAMJGLBE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, FLDEHOGEGMO timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, FLDEHOGEGMO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21DF220", Offset = "0x21DD820", VA = "0x1821DF220", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FLDEHOGEGMO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x42F1ED0", Offset = "0x42F04D0", VA = "0x1842F1ED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21DF310", Offset = "0x21DD910", VA = "0x1821DF310")]
		[DebuggerHidden]
		public LPKGDPKOAFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x42F1F30", Offset = "0x42F0530", VA = "0x1842F1F30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x42F1550", Offset = "0x42EFB50", VA = "0x1842F1550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x42F14F0", Offset = "0x42EFAF0", VA = "0x1842F14F0")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x42F1490", Offset = "0x42EFA90", VA = "0x1842F1490")]
		private void DLKKNIILKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x42F1E80", Offset = "0x42F0480", VA = "0x1842F1E80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x42F1D40", Offset = "0x42F0340", VA = "0x1842F1D40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FLDEHOGEGMO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x42F1E40", Offset = "0x42F0440", VA = "0x1842F1E40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, FLDEHOGEGMO, PBGLEKOCCEM> GGIIDLPJPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, FLDEHOGEGMO, PBGLEKOCCEM> ODDMIIBCBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<KEFLMHFIOFB<TKey>, PBGLEKOCCEM> JCNPMIAEMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JJGFAMJGLBE IBKNNAJIBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool LFHFPMACPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int CGKENADCAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch JCKIGCCHOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int HOHMJDOHNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string DNOBFBPPHCF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JJGFAMJGLBE AIFFJGDFOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string DKBPELCIKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86ADF0", Offset = "0x8693F0", VA = "0x18086ADF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x416EBE0", Offset = "0x416D1E0", VA = "0x18416EBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x416EDE0", Offset = "0x416D3E0", VA = "0x18416EDE0")]
	public KEFLMHFIOFB(TKey COKBAGHKINO, PBGLEKOCCEM APPJEAMJBHK, [Optional] int? NJKGEFNPFBB, [Optional][CanBeNull] Stopwatch JCKIGCCHOGP, [Optional] Action<TKey, FLDEHOGEGMO, PBGLEKOCCEM> GGIIDLPJPNL, [Optional] Action<TKey, FLDEHOGEGMO, PBGLEKOCCEM> ODDMIIBCBJM, [Optional] Action<KEFLMHFIOFB<TKey>, PBGLEKOCCEM> JCNPMIAEMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x416EB00", Offset = "0x416D100", VA = "0x18416EB00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x416ED30", Offset = "0x416D330", VA = "0x18416ED30")]
	[IteratorStateMachine(typeof(KEFLMHFIOFB<>.CCLNDKALPME))]
	public IEnumerable<(TKey, List<TKey>, FLDEHOGEGMO)> NBAEHIJHJHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x416EC40", Offset = "0x416D240", VA = "0x18416EC40")]
	[IteratorStateMachine(typeof(KEFLMHFIOFB<>.LPKGDPKOAFO))]
	private IEnumerable<(TKey, List<TKey>, FLDEHOGEGMO)> NBAEHIJHJHA(List<TKey> ILDIFEDDEBK, JJGFAMJGLBE PBEAFOOLDGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x416EA80", Offset = "0x416D080", VA = "0x18416EA80")]
	private (long, int) BDODAEJPALF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class PHIDKIIKALN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut HJNGFABCEEC(KEFLMHFIOFB<TKey> LAEFIIJCIDG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	protected PHIDKIIKALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class KOLNDBEEPOE<TKey> : PHIDKIIKALN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string GGPLNAIFLPH(TKey IBBDLGCDELM);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x41CC700", Offset = "0x41CAD00", VA = "0x1841CC700")]
	private static string CDJIMJINHIG(TKey IBBDLGCDELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x41CC8A0", Offset = "0x41CAEA0", VA = "0x1841CC8A0", Slot = "4")]
	public override string HJNGFABCEEC(KEFLMHFIOFB<TKey> LAEFIIJCIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x41CC740", Offset = "0x41CAD40", VA = "0x1841CC740")]
	public string HJNGFABCEEC(KEFLMHFIOFB<TKey> LAEFIIJCIDG, [NotNull] GGPLNAIFLPH MDJONAODOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DHKHIFMKNDA(KEFLMHFIOFB<TKey> LAEFIIJCIDG, [NotNull] GGPLNAIFLPH MDJONAODOLI);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3DA26A0", Offset = "0x3DA0CA0", VA = "0x183DA26A0")]
	protected KOLNDBEEPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class KKAOAMKLJOE<TKey> : PHIDKIIKALN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string FGPFJKPHFBB(TKey IBBDLGCDELM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string JGMIGCFHPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double MACNEOPGLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool IAACMHPHGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int DKHHMCLHAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> CPFNJGLJIHI;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x41BC4B0", Offset = "0x41BAAB0", VA = "0x1841BC4B0")]
	private static string CDJIMJINHIG(TKey IBBDLGCDELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x41BD010", Offset = "0x41BB610", VA = "0x1841BD010")]
	public KKAOAMKLJOE(string JGMIGCFHPON = "F2", double MACNEOPGLCB = double.MaxValue, bool IAACMHPHGPI = false, int DKHHMCLHAIH = int.MaxValue, [Optional] ISet<string> CPFNJGLJIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x41BCB40", Offset = "0x41BB140", VA = "0x1841BCB40", Slot = "4")]
	public override Dictionary<string, string> HJNGFABCEEC(KEFLMHFIOFB<TKey> LAEFIIJCIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x41BC3D0", Offset = "0x41BA9D0", VA = "0x1841BC3D0")]
	private bool CAMEGMGNIJH(string LDEGDFBKKLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x41BC4F0", Offset = "0x41BAAF0", VA = "0x1841BC4F0")]
	public Dictionary<string, string> HJNGFABCEEC(KEFLMHFIOFB<TKey> LAEFIIJCIDG, FGPFJKPHFBB MDJONAODOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x41BCD90", Offset = "0x41BB390", VA = "0x1841BCD90")]
	private string LFAPBKKABHE(StringBuilder DPBHJJEIONN, List<TKey> DLOFNFOLJNG, FGPFJKPHFBB MDJONAODOLI, bool DBOANHNOCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x41BCC30", Offset = "0x41BB230", VA = "0x1841BCC30")]
	private static void HPDMOKEAKBO(StringBuilder DMBHNPOIEGM, string EGOBBKMGGFI, bool IBIFMFCDLCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class CBJCHLMHNKN<TKey> : KOLNDBEEPOE<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct MEADAGAAHKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public GGPLNAIFLPH keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static CBJCHLMHNKN<TKey> CFNNMJAMDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] NPJGOOMMMHG;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x51AADD0", Offset = "0x51A93D0", VA = "0x1851AADD0")]
	private CBJCHLMHNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x51A9D10", Offset = "0x51A8310", VA = "0x1851A9D10", Slot = "5")]
	protected override string DHKHIFMKNDA(KEFLMHFIOFB<TKey> LAEFIIJCIDG, GGPLNAIFLPH MDJONAODOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x51AAB70", Offset = "0x51A9170", VA = "0x1851AAB70")]
	[CompilerGenerated]
	internal static string FPMIDCAJCHA(string AGICCMHBBOP, TKey IBBDLGCDELM, MEADAGAAHKI P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PLHFNLKGHIF : KEFLMHFIOFB<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MLGLENIGCAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<PLHFNLKGHIF, PBGLEKOCCEM> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public MLGLENIGCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x69D9990", Offset = "0x69D7F90", VA = "0x1869D9990")]
		internal void ENBDMHFNBGM(KEFLMHFIOFB<string> timer, PBGLEKOCCEM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69D9C90", Offset = "0x69D8290", VA = "0x1869D9C90")]
	public PLHFNLKGHIF(PBGLEKOCCEM APPJEAMJBHK, [Optional] string FADOBDANEMN, [Optional] int? NJKGEFNPFBB, [Optional] Stopwatch JCKIGCCHOGP, [Optional] Action<string, FLDEHOGEGMO, PBGLEKOCCEM> GGIIDLPJPNL, [Optional] Action<string, FLDEHOGEGMO, PBGLEKOCCEM> ODDMIIBCBJM, [Optional] Action<PLHFNLKGHIF, PBGLEKOCCEM> JCNPMIAEMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x69D9BD0", Offset = "0x69D81D0", VA = "0x1869D9BD0")]
	private static Action<KEFLMHFIOFB<string>, PBGLEKOCCEM> LOLHAPEFAEE(Action<PLHFNLKGHIF, PBGLEKOCCEM> JMMEJHGHOEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class LFDFBGKIOBE
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class HOHDIKLMADB : LFDFBGKIOBE
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static LFDFBGKIOBE CFNNMJAMDBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x69D9590", Offset = "0x69D7B90", VA = "0x1869D9590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float GKCHDFKJCLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9D3460", Offset = "0x9D1A60", VA = "0x1809D3460", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x69D9690", Offset = "0x69D7C90", VA = "0x1869D9690")]
		public HOHDIKLMADB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static LFDFBGKIOBE JINJGAMIBAC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static LFDFBGKIOBE ABMFDACMOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x69D9760", Offset = "0x69D7D60", VA = "0x1869D9760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float GKCHDFKJCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	protected LFDFBGKIOBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface CDLFAMOJMBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool DBIJCBPOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FNMJFLPICID<T> : CDLFAMOJMBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> EKNINJIIECK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	FGBFKCLKPNC<T> NLICALLLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OGHCLGJOJLF
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7440", Offset = "0x2CF5A40", VA = "0x182CF7440")]
	public static FNMJFLPICID<TResource> CBMGKDDBOFO<TResource, TId>(this JGOBKBHEPCF<TId, TResource> HIIEEHBAEND, TId DAIJJLLIENA, [Optional] Func<TId, CancellationToken, Task<TResource>>? JDEIOPOJELC) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class IBBBGEFDKNE
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class DHNJHBPLPFK<T> : DOACJLDMKIP<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> EKNINJIIECK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override FGBFKCLKPNC<T?> NLICALLLNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x58CA1D0", Offset = "0x58C87D0", VA = "0x1858CA1D0")]
		public DHNJHBPLPFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "10")]
		protected override void ACGJBHMIKAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class PDFEHBEELKI<T> : DOACJLDMKIP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly T DKAKEMDLEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Action<T>? AANDLJELEPJ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> EKNINJIIECK
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override FGBFKCLKPNC<T> NLICALLLNBF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4799740", Offset = "0x4797D40", VA = "0x184799740")]
		public PDFEHBEELKI(T MCJNLHJBMKC, Action<T>? IIPPFKJLDIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x47996E0", Offset = "0x4797CE0", VA = "0x1847996E0", Slot = "10")]
		protected override void ACGJBHMIKAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class KHKKFOOOKAI<T> : DOACJLDMKIP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> EKNINJIIECK
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override FGBFKCLKPNC<T> NLICALLLNBF
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x41B38C0", Offset = "0x41B1EC0", VA = "0x1841B38C0")]
		public KHKKFOOOKAI(Exception PAPBNEGEKNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "10")]
		protected override void ACGJBHMIKAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class AFKMLHMPBMD<T> : DOACJLDMKIP<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct KHJDJHBEKJL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<FNMJFLPICID<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<FNMJFLPICID<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x41B2DC0", Offset = "0x41B13C0", VA = "0x1841B2DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x41B3820", Offset = "0x41B1E20", VA = "0x1841B3820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct PKBCBFBGELN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<FNMJFLPICID<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<FNMJFLPICID<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x47F8A30", Offset = "0x47F7030", VA = "0x1847F8A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x47F8C70", Offset = "0x47F7270", VA = "0x1847F8C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Task<FNMJFLPICID<T>> HAKDLLPJJMD;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> EKNINJIIECK
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override FGBFKCLKPNC<T> NLICALLLNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3CB54D0", Offset = "0x3CB3AD0", VA = "0x183CB54D0")]
		public AFKMLHMPBMD(Task<FNMJFLPICID<T>> NAFOIMCAMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4ED0", Offset = "0x3CB34D0", VA = "0x183CB4ED0", Slot = "10")]
		protected override void ACGJBHMIKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5350", Offset = "0x3CB3950", VA = "0x183CB5350")]
		[AsyncStateMachine(typeof(AFKMLHMPBMD<>.KHJDJHBEKJL))]
		[CompilerGenerated]
		internal static Task<T> LEEKFHHJBOG(Task<FNMJFLPICID<T>> NAFOIMCAMMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4FF0", Offset = "0x3CB35F0", VA = "0x183CB4FF0")]
		[AsyncStateMachine(typeof(AFKMLHMPBMD<>.PKBCBFBGELN))]
		[CompilerGenerated]
		internal static Task HMJAKMOGEOO(Task<FNMJFLPICID<T>> NAFOIMCAMMG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class IJHFJMOLEEN<TIn, TOut> : DOACJLDMKIP<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct EANLHHKICMM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3854740", Offset = "0x3852D40", VA = "0x183854740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3854AC0", Offset = "0x38530C0", VA = "0x183854AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly FNMJFLPICID<TIn> MHCBIMLHFDG;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<TOut> EKNINJIIECK
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override FGBFKCLKPNC<TOut> NLICALLLNBF
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B430", Offset = "0x3E79A30", VA = "0x183E7B430")]
		public IJHFJMOLEEN(FNMJFLPICID<TIn> IODCBFNDCPO, Func<TIn, TOut> PMBIEFMPPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B070", Offset = "0x3E79670", VA = "0x183E7B070", Slot = "10")]
		protected override void ACGJBHMIKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B2A0", Offset = "0x3E798A0", VA = "0x183E7B2A0")]
		[AsyncStateMachine(typeof(IJHFJMOLEEN<, >.EANLHHKICMM))]
		[CompilerGenerated]
		internal static Task<TOut> AHNGGNBCBEJ(Task<TIn> BKFICFCCFKI, Func<TIn, TOut> PMBIEFMPPCF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1480", Offset = "0x2BBFA80", VA = "0x182BC1480")]
	public static FNMJFLPICID<T> CHPFPNHMMDE<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1500", Offset = "0x2BBFB00", VA = "0x182BC1500")]
	public static FNMJFLPICID<T> JAEEPGMNHJJ<T>(T IAFCFGOKEAK, [Optional] Action<T>? IIPPFKJLDIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4740", Offset = "0x2BA2D40", VA = "0x182BA4740")]
	public static FNMJFLPICID<T> FNNJLJAEGNB<T>(Exception PAPBNEGEKNJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4740", Offset = "0x2BA2D40", VA = "0x182BA4740")]
	public static FNMJFLPICID<T> PLGBCLBMNMN<T>(Task<FNMJFLPICID<T>> NAFOIMCAMMG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x29A5D90", Offset = "0x29A4390", VA = "0x1829A5D90")]
	public static FNMJFLPICID<TOut> BIPGCHCOEKG<TOut, TIn>(FNMJFLPICID<TIn> FPDGNDMPHII, Func<TIn, TOut> PMBIEFMPPCF) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class DOACJLDMKIP<T> : FNMJFLPICID<T>, CDLFAMOJMBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly string MMODDFLDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly MOPBPKFEPJN BDNGCGKKEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool LFHFPMACPBD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool DBIJCBPOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xBD0A60", Offset = "0xBCF060", VA = "0x180BD0A60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public abstract Task<T> EKNINJIIECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract FGBFKCLKPNC<T> NLICALLLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x58E9E80", Offset = "0x58E8480", VA = "0x1858E9E80")]
	public DOACJLDMKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x58E9AD0", Offset = "0x58E80D0", VA = "0x1858E9AD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void ACGJBHMIKAN();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class FAHFNGIGPAM<TTask, T> : DOACJLDMKIP<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class BHMBCGDMFAE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public BHMBCGDMFAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x35C30C0", Offset = "0x35C16C0", VA = "0x1835C30C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x35C3390", Offset = "0x35C1990", VA = "0x1835C3390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public FAHFNGIGPAM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public BHMBCGDMFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5AD0", Offset = "0x4ED40D0", VA = "0x184ED5AD0")]
		[AsyncStateMachine(typeof(FAHFNGIGPAM<, >.BHMBCGDMFAE.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> FEDJEDMNPDP(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Task<T> NAFOIMCAMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly CancellationTokenSource OGOBIEKOEBM;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> EKNINJIIECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override FGBFKCLKPNC<T> NLICALLLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6CE0", Offset = "0x3BF52E0", VA = "0x183BF6CE0")]
	protected FAHFNGIGPAM(TTask NAFOIMCAMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6C90", Offset = "0x3BF5290", VA = "0x183BF6C90", Slot = "10")]
	protected override void ACGJBHMIKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T GMJNNBFHLAH(TTask JPIANKHMFMF);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void BJAMHFCKFPL();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class IHPIIEMDGLJ<T> : DOACJLDMKIP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly AHJCAINOMHJ<Task<T>> KCFFNDJGKFJ;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> EKNINJIIECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3C094B0", Offset = "0x3C07AB0", VA = "0x183C094B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override FGBFKCLKPNC<T> NLICALLLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3E79BE0", Offset = "0x3E781E0", VA = "0x183E79BE0")]
	public IHPIIEMDGLJ(AHJCAINOMHJ<Task<T>> GCMOLPMMHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3E79BC0", Offset = "0x3E781C0", VA = "0x183E79BC0", Slot = "10")]
	protected override void ACGJBHMIKAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class CGGJBODBGHH
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static readonly HashAlgorithmName GNJDCEFGMOG;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly ThreadLocal<IncrementalHash> EEJDPDNJMKA;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x69D78B0", Offset = "0x69D5EB0", VA = "0x1869D78B0")]
	public static int JNICIOPOKFO(this MAGJMGHKFJB MKLHMPLJJGO, IncrementalHash JEEDPHFPHKM, byte[] HIGOEELJEED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x69D8000", Offset = "0x69D6600", VA = "0x1869D8000")]
	public static bool LAIDKMGGIOA([CanBeNull] this MAGJMGHKFJB MKLHMPLJJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x69D79C0", Offset = "0x69D5FC0", VA = "0x1869D79C0")]
	public static bool LAIDKMGGIOA([CanBeNull] this MAGJMGHKFJB MKLHMPLJJGO, [Out] string ENLEFDLBBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x69D7CD0", Offset = "0x69D62D0", VA = "0x1869D7CD0")]
	public static bool LAIDKMGGIOA([CanBeNull] this MAGJMGHKFJB MKLHMPLJJGO, IncrementalHash JEEDPHFPHKM, byte[] HIGOEELJEED, [Out] string ENLEFDLBBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x69D7930", Offset = "0x69D5F30", VA = "0x1869D7930")]
	private static bool KOAIDBFPGKA(byte[] LDMLGCNFLMP, Span<byte> ICBMGAPMIAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class AOMMHPCODIB
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x69D5E70", Offset = "0x69D4470", VA = "0x1869D5E70")]
	public static int GKMGELNAPAE(HashAlgorithmName BAHGEEFIHNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x69D5FC0", Offset = "0x69D45C0", VA = "0x1869D5FC0")]
	public static int JNICIOPOKFO(this NKDJHGEIMFA LEOEIHIPJGJ, byte[] EDMPGKHIOIA, IncrementalHash JEEDPHFPHKM, byte[] CCALJLHBHHH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface NKDJHGEIMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JEEDPHFPHKM);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface MAGJMGHKFJB : NKDJHGEIMFA
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] AAPJOKIKFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] DJIBAMMALPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BCMBACBGLEG
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static bool HFMNJIAKCBL;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ArrayPool<byte> JFKKDCHPFID;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly ArrayPool<char> JDNIBFOPDNK;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly Encoding OGBHMPFMBHG;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ThreadLocal<Encoder> ACPGEMHFPGK;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x292AEA0", Offset = "0x29294A0", VA = "0x18292AEA0")]
	public static void PBNFKIKKBAJ<T>(this IncrementalHash LJAGMKPILJG, [CanBeNull] T JLFHFDLINDL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x292AE10", Offset = "0x2929410", VA = "0x18292AE10")]
	public static void HAELEGFFJLL<T>(this IncrementalHash LJAGMKPILJG, [CanBeNull] T LEOEIHIPJGJ) where T : NKDJHGEIMFA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x292A2C0", Offset = "0x29288C0", VA = "0x18292A2C0")]
	public static void BLGMNJPLIAE<T>(this IncrementalHash LJAGMKPILJG, [CanBeNull] IList<T> PNMJLBNFFKK) where T : NKDJHGEIMFA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x69D6220", Offset = "0x69D4820", VA = "0x1869D6220")]
	private static bool CKINKHIAJFD([CanBeNull] NKDJHGEIMFA LEOEIHIPJGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x69D6B20", Offset = "0x69D5120", VA = "0x1869D6B20")]
	public static void LNGHJBOPENO(this IncrementalHash JEEDPHFPHKM, string? ECDJFLLIGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x69D62B0", Offset = "0x69D48B0", VA = "0x1869D62B0")]
	public static void CPLIHCHLBIA(this IncrementalHash JEEDPHFPHKM, long HKIHBNFIKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x69D6890", Offset = "0x69D4E90", VA = "0x1869D6890")]
	public static void IEOBGGJGHCP(this IncrementalHash JEEDPHFPHKM, int NLBDLEHMFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x69D6F30", Offset = "0x69D5530", VA = "0x1869D6F30")]
	public static void OFLCGLJJMHI(this IncrementalHash JEEDPHFPHKM, short GNCFBCAHLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x69D6480", Offset = "0x69D4A80", VA = "0x1869D6480")]
	public static void DGJMNHAKGIP(this IncrementalHash JEEDPHFPHKM, byte CAKBLGCDCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x69D6590", Offset = "0x69D4B90", VA = "0x1869D6590")]
	public static void EPOJBLHLEJL(this IncrementalHash JEEDPHFPHKM, bool EHEHGFKMNPK, bool PBEIGLKHEID = false, bool EBIIKGMGOOE = false, bool LMDJKIAILDC = false, bool MLGELEHHIBP = false, bool MINKPLHFMMK = false, bool GLAOCHJAEEO = false, bool CGCHMPNILAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x292A7E0", Offset = "0x2928DE0", VA = "0x18292A7E0")]
	public static void FBABHDKLGOL<T>(this IncrementalHash JEEDPHFPHKM, T ANPOJJGGDDM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x69D7100", Offset = "0x69D5700", VA = "0x1869D7100")]
	public static void OMPPCDDPLFH(this IncrementalHash JEEDPHFPHKM, float FCAIACPJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x69D6A60", Offset = "0x69D5060", VA = "0x1869D6A60")]
	public static void IMMNPJLPIDL(this IncrementalHash JEEDPHFPHKM, ulong IMAHBPMCHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x69D6700", Offset = "0x69D4D00", VA = "0x1869D6700")]
	public static void FKMPHEGCPCD(this IncrementalHash JEEDPHFPHKM, uint KFLGDMGKGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x69D6AC0", Offset = "0x69D50C0", VA = "0x1869D6AC0")]
	public static void LGJLLIBLKEC(this IncrementalHash JEEDPHFPHKM, ushort FHBGAPMEDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x69D6760", Offset = "0x69D4D60", VA = "0x1869D6760")]
	public static void HHMGOKBNCIA(this IncrementalHash JEEDPHFPHKM, Vector3 HJBJJKGBJPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class PBKHKOGLKAJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x69D9B70", Offset = "0x69D8170", VA = "0x1869D9B70")]
	public PBKHKOGLKAJ(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public abstract class IDEOCIAAPDI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class EINFLFCMNDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TNode HLIDMKMINHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TNode PPEEAFEPIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public LHDFPNNBHOP CAAMCMKANHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<LHDFPNNBHOP> COALNIFMKHA;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public EINFLFCMNDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal struct LHDFPNNBHOP : IComparable<LHDFPNNBHOP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int LOLKACMOLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public TClaimant KKCNIAELNIJ;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xDF1F20", Offset = "0xDF0520", VA = "0x180DF1F20")]
		public LHDFPNNBHOP(int LOLKACMOLOC, TClaimant KKCNIAELNIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x42D6EE0", Offset = "0x42D54E0", VA = "0x1842D6EE0")]
		public bool PFKCFHFNJNL([In] LHDFPNNBHOP BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x42D6ED0", Offset = "0x42D54D0", VA = "0x1842D6ED0")]
		public bool HFOJCAKIEMC([In] LHDFPNNBHOP BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x42D6EC0", Offset = "0x42D54C0", VA = "0x1842D6EC0", Slot = "4")]
		public int CompareTo(LHDFPNNBHOP BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x42D6F40", Offset = "0x42D5540", VA = "0x1842D6F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum OOPBLIFEHAF
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class NDCGBJDMDMF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public IDEOCIAAPDI<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
		[DebuggerHidden]
		public NDCGBJDMDMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x455D600", Offset = "0x455BC00", VA = "0x18455D600", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x455D7E0", Offset = "0x455BDE0", VA = "0x18455D7E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x455D6E0", Offset = "0x455BCE0", VA = "0x18455D6E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3876950", Offset = "0x3874F50", VA = "0x183876950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly OCDMEAEINPK<EINFLFCMNDG> AHGOHEMIFGG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly OCDMEAEINPK<List<LHDFPNNBHOP>> OFJEBNDONIO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static int PCHLCEIEKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal readonly Dictionary<TClaimant, TNode> OMIJDLAGFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal readonly Dictionary<TNode, EINFLFCMNDG> EDIEEAOEPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private OOPBLIFEHAF HIHEPGOGOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool DALIKEFGADH;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AFHOOHJCNBG(TNode EMDFCFPCFGG);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CJHBCNNGCFJ(TNode EMDFCFPCFGG, TClaimant ABOEGIJJEBM, TClaimant IEHDBECIADB);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3E57F70", Offset = "0x3E56570", VA = "0x183E57F70")]
	public IDEOCIAAPDI(OOPBLIFEHAF HIHEPGOGOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3E578E0", Offset = "0x3E55EE0", VA = "0x183E578E0")]
	public void NHPGFLGIHHM(TNode EMDFCFPCFGG, TNode MBKJJMHGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3E56F10", Offset = "0x3E55510", VA = "0x183E56F10")]
	public void KDBMEDHAFIA(TClaimant KKCNIAELNIJ, TNode LNKONCHCFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3E568F0", Offset = "0x3E54EF0", VA = "0x183E568F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3E57CB0", Offset = "0x3E562B0", VA = "0x183E57CB0")]
	private void PPENOGILNPH(TClaimant KKCNIAELNIJ, TNode IIBPJHNHLFK, TNode LNKONCHCFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3E56D40", Offset = "0x3E55340", VA = "0x183E56D40")]
	private int IOIPMOCEMKN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3E573B0", Offset = "0x3E559B0", VA = "0x183E573B0")]
	private void KPMKONDFEJL(TClaimant KKCNIAELNIJ, TNode AMBEPGENEJG, TNode JGNLPHMJMEF, int PDNPLKCHOCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3E56B20", Offset = "0x3E55120", VA = "0x183E56B20")]
	private void EAHFJNLCHDA(LHDFPNNBHOP BKMGCNKILIG, EINFLFCMNDG LFGGKMKJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3E579B0", Offset = "0x3E55FB0", VA = "0x183E579B0")]
	private void PKBJIFFHAAC(TClaimant KKCNIAELNIJ, TNode AMBEPGENEJG, TNode JGNLPHMJMEF, int PDNPLKCHOCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3E56C00", Offset = "0x3E55200", VA = "0x183E56C00")]
	private void IGGALKLDNMO(LHDFPNNBHOP BKMGCNKILIG, TNode EMDFCFPCFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3E57240", Offset = "0x3E55840", VA = "0x183E57240")]
	private void KPLKAIIKFEI(LHDFPNNBHOP BKMGCNKILIG, EINFLFCMNDG LFGGKMKJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3E56DB0", Offset = "0x3E553B0", VA = "0x183E56DB0")]
	private void JFEAANBOFCL(EINFLFCMNDG LFGGKMKJGKE, bool DFJIBIGEPGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3E56360", Offset = "0x3E54960", VA = "0x183E56360")]
	private void BFOLJPIKBHM(EINFLFCMNDG LFGGKMKJGKE, TNode MBKJJMHGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3E566D0", Offset = "0x3E54CD0", VA = "0x183E566D0")]
	[IteratorStateMachine(typeof(IDEOCIAAPDI<, >.NDCGBJDMDMF))]
	private IEnumerable<TNode> CIPLEALLNBE(TNode AMBEPGENEJG, TNode JGNLPHMJMEF, bool JAFBNGBNDKI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3E567D0", Offset = "0x3E54DD0", VA = "0x183E567D0")]
	private EINFLFCMNDG DLOKLMBNAHC(TNode EMDFCFPCFGG, TNode PPEEAFEPIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3E570B0", Offset = "0x3E556B0", VA = "0x183E570B0")]
	private EINFLFCMNDG KOAKHIOEKAO(TNode EMDFCFPCFGG, TNode PPEEAFEPIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3E57710", Offset = "0x3E55D10", VA = "0x183E57710")]
	private void LILAKIGBPJP(EINFLFCMNDG LFGGKMKJGKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class EIOACLLPMOC<T> : IEnumerable<EIOACLLPMOC<T>.AMICKKPNGJK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct AMICKKPNGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public T DMNGPNKHPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int PDMMEDBMFPP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class CBOHJOKOIDF : IEnumerator<AMICKKPNGJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private EIOACLLPMOC<T> PPJPBKONHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int PDMMEDBMFPP;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x389BE90", Offset = "0x389A490", VA = "0x18389BE90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AMICKKPNGJK FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x51AB110", Offset = "0x51A9710", VA = "0x1851AB110", Slot = "4")]
			get
			{
				return default(AMICKKPNGJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x51AB020", Offset = "0x51A9620", VA = "0x1851AB020")]
		public CBOHJOKOIDF(EIOACLLPMOC<T> PPJPBKONHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x51AAF20", Offset = "0x51A9520", VA = "0x1851AAF20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38F1C90", Offset = "0x38F0290", VA = "0x1838F1C90", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x961040", Offset = "0x95F640", VA = "0x180961040", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct LHJLMEODMOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool JGNMLKCALJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public T DMNGPNKHPKF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const int AJNHNILNKPO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<T, int> BGPILMKGNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private LHJLMEODMOM[] FHBLJNKIDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int LCOPJKBDHFC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int AMOKNBLMKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C50", Offset = "0x8A4250", VA = "0x1808A5C50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A5800", Offset = "0x8A3E00", VA = "0x1808A5800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x35D58A0", Offset = "0x35D3EA0", VA = "0x1835D58A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x38781E0", Offset = "0x38767E0", VA = "0x1838781E0")]
	public EIOACLLPMOC(int PLGOIBDCNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3878720", Offset = "0x3876D20", VA = "0x183878720")]
	public EIOACLLPMOC(AMICKKPNGJK[] GPLPDNCENAO, bool KLBCCAJPOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x38777B0", Offset = "0x3875DB0", VA = "0x1838777B0")]
	public int CLEAKJBIJFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3877590", Offset = "0x3875B90", VA = "0x183877590")]
	private int AECEGGLJGEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3877E70", Offset = "0x3876470", VA = "0x183877E70", Slot = "6")]
	protected virtual uint FKIGLJCEHPL(uint JEEDPHFPHKM, T DMNGPNKHPKF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x38780E0", Offset = "0x38766E0", VA = "0x1838780E0")]
	public bool NGIDLKBOHNE(T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3877ED0", Offset = "0x38764D0", VA = "0x183877ED0")]
	public int MDPJBLEKEKH(T DMNGPNKHPKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3877300", Offset = "0x3875900", VA = "0x183877300")]
	public T AACDCMAOBJC(int PDMMEDBMFPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3877DA0", Offset = "0x38763A0", VA = "0x183877DA0")]
	public bool FJEHGINIDKI(T DMNGPNKHPKF, bool APMACJCFHBF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3877B30", Offset = "0x3876130", VA = "0x183877B30")]
	public bool FJEHGINIDKI(T DMNGPNKHPKF, int PDMMEDBMFPP, bool APMACJCFHBF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3877FE0", Offset = "0x38765E0", VA = "0x183877FE0")]
	private int MEMLLIKCMCE(int CMKHMGALFJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3878140", Offset = "0x3876740", VA = "0x183878140", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3878140", Offset = "0x3876740", VA = "0x183878140", Slot = "4")]
	private IEnumerator<AMICKKPNGJK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class OCDMEAEINPK<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<T> BABPFPJMACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly List<T> KHBCOONHIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int IJABLODIOCP;

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x46BF990", Offset = "0x46BDF90", VA = "0x1846BF990")]
	public static OCDMEAEINPK<T> AKNAHFPKDCF(int PLGOIBDCNBN = 0, int IJABLODIOCP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x46C0210", Offset = "0x46BE810", VA = "0x1846C0210")]
	public static OCDMEAEINPK<T> OLANJKEAJIG(int PLGOIBDCNBN = 0, int IJABLODIOCP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x46C0530", Offset = "0x46BEB30", VA = "0x1846C0530")]
	public OCDMEAEINPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x46C0310", Offset = "0x46BE910", VA = "0x1846C0310")]
	public OCDMEAEINPK(int PLGOIBDCNBN, int IJABLODIOCP = int.MaxValue, bool KGEFPDNOILE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x46C0050", Offset = "0x46BE650", VA = "0x1846C0050")]
	public T MFHJCEBKALF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x46BFC70", Offset = "0x46BE270", VA = "0x1846BFC70")]
	public void EKHKOALGJHM(T DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x46BFF50", Offset = "0x46BE550", VA = "0x1846BFF50")]
	private void KENOFGLAIPP(T DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x46BFA90", Offset = "0x46BE090", VA = "0x1846BFA90")]
	private void CMLDMNJLEGD(T DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x46BFAE0", Offset = "0x46BE0E0", VA = "0x1846BFAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x46BFD50", Offset = "0x46BE350", VA = "0x1846BFD50")]
	private void JNGLGBJHHKN(IEnumerable<T> EJHPODPBOEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DFFMBIAGBNJ<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Dictionary<int, T> CJCKCFPDODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private T APMLOICEBEN;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T MOMNGNDHGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x58C1880", Offset = "0x58BFE80", VA = "0x1858C1880")]
	public bool IOOGOHAPAFI(T DMNGPNKHPKF, int LOLKACMOLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x47BA3E0", Offset = "0x47B89E0", VA = "0x1847BA3E0")]
	public bool IKNHMJKPFOG(int LOLKACMOLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x58C1470", Offset = "0x58BFA70", VA = "0x1858C1470")]
	public T GECEEJHBAKJ(int JFANLBJANID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x58C19E0", Offset = "0x58BFFE0", VA = "0x1858C19E0")]
	private bool JFKFHEKFKBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x58C1410", Offset = "0x58BFA10", VA = "0x1858C1410")]
	public bool APLEJEFPFAB(int LOLKACMOLOC, [Out] T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x47BC660", Offset = "0x47BAC60", VA = "0x1847BC660")]
	public DFFMBIAGBNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class EDEJCHNODMI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	protected struct KONHDLCMALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public T FJLALGMPANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int DLNOMCBAPBP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected readonly List<KONHDLCMALF> BHDAJGDNINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private T CIACGJELDCE;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x35D58A0", Offset = "0x35D3EA0", VA = "0x1835D58A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x385A380", Offset = "0x3858980", VA = "0x18385A380")]
	public bool LGJHGFMDMBF(T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x385A730", Offset = "0x3858D30", VA = "0x18385A730")]
	public void LHEPNGLDBLI(T DMNGPNKHPKF, int LOLKACMOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3859D50", Offset = "0x3858350", VA = "0x183859D50")]
	public bool HHOKGKJNBNI(T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3859B10", Offset = "0x3858110", VA = "0x183859B10")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3859F60", Offset = "0x3858560", VA = "0x183859F60")]
	public T IBHBNNPNBBC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x385A0A0", Offset = "0x38586A0", VA = "0x18385A0A0")]
	protected void ILHJCEHJGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x385A8D0", Offset = "0x3858ED0", VA = "0x18385A8D0")]
	public EDEJCHNODMI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x69D9F20", Offset = "0x69D8520", VA = "0x1869D9F20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x69DA1F0", Offset = "0x69D87F0", VA = "0x1869DA1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x69DA100", Offset = "0x69D8700", VA = "0x1869DA100")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x69D9E70", Offset = "0x69D8470", VA = "0x1869D9E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x69DA140", Offset = "0x69D8740", VA = "0x1869DA140")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x69DA050", Offset = "0x69D8650", VA = "0x1869DA050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x69D9DE0", Offset = "0x69D83E0", VA = "0x1869D9DE0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x49B5ED0", Offset = "0x49B44D0", VA = "0x1849B5ED0", Slot = "4")]
		public virtual T KMLPEDNDMDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GEKLIBJDGMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Dictionary<byte, BPEPEIOCFBC> LCAKKPILKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly OCDMEAEINPK<BPEPEIOCFBC> MDGCCMAANNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly bool PCNEFIBDIBL;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public BPEPEIOCFBC LENLCEOKIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 CGEANKEHKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xD6BEC0", Offset = "0xD6A4C0", VA = "0x180D6BEC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x104D6A0", Offset = "0x104BCA0", VA = "0x18104D6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 BHJFLOHDAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x10B3F10", Offset = "0x10B2510", VA = "0x1810B3F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 HHKGJPBLOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x69D8940", Offset = "0x69D6F40", VA = "0x1869D8940")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x868EF0", Offset = "0x8674F0", VA = "0x180868EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int PJFLJAEHBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x874B30", Offset = "0x873130", VA = "0x180874B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x874EB0", Offset = "0x8734B0", VA = "0x180874EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x69D94D0", Offset = "0x69D7AD0", VA = "0x1869D94D0")]
	public GEKLIBJDGMJ(Bounds DHGAKMMPIDB, Vector2[] KLBNCCCLPEE, int NNMLOELIKNE, byte CMKHMGALFJE, float BHJNJKLJMMG = 0f, [Optional] OCDMEAEINPK<BPEPEIOCFBC> MDGCCMAANNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x69D8F40", Offset = "0x69D7540", VA = "0x1869D8F40")]
	public void OINOICLJDFD(Bounds DHGAKMMPIDB, Vector2[] KLBNCCCLPEE, int NNMLOELIKNE, byte CMKHMGALFJE, float BHJNJKLJMMG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69D88E0", Offset = "0x69D6EE0", VA = "0x1869D88E0")]
	public BPEPEIOCFBC KANFHEEFFLI(byte PDMMEDBMFPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69D8510", Offset = "0x69D6B10", VA = "0x1869D8510")]
	public void DOKGPJLBLLA(Vector3 MCPNOOFMAHG, float DMAKEFAHCCL, float DOJFBFGKNAK, List<byte> ONCPDOKKJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x69D88C0", Offset = "0x69D6EC0", VA = "0x1869D88C0")]
	public void GGMCHMBCCGB(BPEPEIOCFBC.HDPPMGELBAB JLPNMBNHLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x69D93E0", Offset = "0x69D79E0", VA = "0x1869D93E0")]
	public static int PHEGCCGPDAI(Vector2[] KLBNCCCLPEE, int NNMLOELIKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69D8D10", Offset = "0x69D7310", VA = "0x1869D8D10")]
	private BPEPEIOCFBC NHBKAHPFCKA(byte PDMMEDBMFPP, BPEPEIOCFBC.HKKCGDLGKCP DACNHBFOHKJ, BPEPEIOCFBC PPEEAFEPIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x69D8960", Offset = "0x69D6F60", VA = "0x1869D8960")]
	private void MBHMLGNKBLM(BPEPEIOCFBC PPEEAFEPIIK, Vector2[] KLBNCCCLPEE, int CNLPLLDILOC, int PMMCHOMHDAE, int PBDPMHFIMGE, int HKODEMIICPL, float BHJNJKLJMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x69D8640", Offset = "0x69D6C40", VA = "0x1869D8640")]
	private void FAANJNDLKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x69D85E0", Offset = "0x69D6BE0", VA = "0x1869D85E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x69D8860", Offset = "0x69D6E60", VA = "0x1869D8860", Slot = "1")]
	~GEKLIBJDGMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BPEPEIOCFBC
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum HKKCGDLGKCP
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum HDPPMGELBAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte LAALHOAJCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Vector3 AKJBDIOFCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Vector3 FPMEMCFLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector3 GNJHFKLAIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 OOLGLJCLBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public HKKCGDLGKCP CCBLICLDGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public BPEPEIOCFBC GPPJHNPGLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<BPEPEIOCFBC> FFDNCINFGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool LILGEDILBBJ;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x69D7890", Offset = "0x69D5E90", VA = "0x1869D7890")]
	public BPEPEIOCFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x69D7660", Offset = "0x69D5C60", VA = "0x1869D7660")]
	public void FNDDDBCIJKM(BPEPEIOCFBC BCMCEBEOPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	public void GGMCHMBCCGB(int LFJHMGOPNHA, HDPPMGELBAB JLPNMBNHLCH, int BKFJGNCEDNF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x69D7400", Offset = "0x69D5A00", VA = "0x1869D7400")]
	public void DOKGPJLBLLA(List<byte> ONCPDOKKJEK, Vector3 MCPNOOFMAHG, float DMAKEFAHCCL, float DOJFBFGKNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x69D77D0", Offset = "0x69D5DD0", VA = "0x1869D77D0")]
	public bool MENKDCHEDMG(Vector3 PKGGNLMKLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x69D77A0", Offset = "0x69D5DA0", VA = "0x1869D77A0")]
	public bool KFBAKMCOHNA(Vector3 PKGGNLMKLOL, float NBBMCAPINFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x69D7800", Offset = "0x69D5E00", VA = "0x1869D7800")]
	public void PNLKNBIHCGI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct AFAPJOIIEKH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> DEPHDEBCNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool KJIGAAHIMPC;

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4EA0", Offset = "0x3CB34A0", VA = "0x183CB4EA0")]
			public AFAPJOIIEKH(List<Component> DEPHDEBCNCK, bool KJIGAAHIMPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4D60", Offset = "0x3CB3360", VA = "0x183CB4D60")]
			public LPHNLAMDOBJ<T> GGGADAADMEJ()
			{
				return default(LPHNLAMDOBJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4DD0", Offset = "0x3CB33D0", VA = "0x183CB4DD0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4DD0", Offset = "0x3CB33D0", VA = "0x183CB4DD0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct LPHNLAMDOBJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> DEPHDEBCNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool KJIGAAHIMPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int PDMMEDBMFPP;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T FOBIFFPGMIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0x42F1390", Offset = "0x42EF990", VA = "0x1842F1390", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x42F1320", Offset = "0x42EF920", VA = "0x1842F1320", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x42F1360", Offset = "0x42EF960", VA = "0x1842F1360")]
			public LPHNLAMDOBJ(List<Component> DEPHDEBCNCK, bool KJIGAAHIMPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x42F1260", Offset = "0x42EF860", VA = "0x1842F1260", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x42F1270", Offset = "0x42EF870", VA = "0x1842F1270", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x38E2530", Offset = "0x38E0B30", VA = "0x1838E2530", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x69DBC40", Offset = "0x69DA240", VA = "0x1869DBC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x69DBA40", Offset = "0x69DA040", VA = "0x1869DBA40")]
		private void PNLKNBIHCGI(GameObject AEHACDADEAN, bool LCIFANAPNML = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x69DB9B0", Offset = "0x69D9FB0", VA = "0x1869DB9B0")]
		public static void PNLKNBIHCGI(GameObject AEHACDADEAN, ToolHierarchyCache HIIEEHBAEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x69DB650", Offset = "0x69D9C50", VA = "0x1869DB650")]
		public void KBHPGFGKAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E999B0", Offset = "0x2E97FB0", VA = "0x182E999B0")]
		public void EIFFFLDKLCP<T>(Action<T> PEMICEIPPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E99BF0", Offset = "0x2E981F0", VA = "0x182E99BF0")]
		public T OEIICIBHHOK<T>(bool KJIGAAHIMPC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E998F0", Offset = "0x2E97EF0", VA = "0x182E998F0")]
		public AFAPJOIIEKH<T> BIJPGDAMACC<T>(bool KJIGAAHIMPC = false) where T : class
		{
			return default(AFAPJOIIEKH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x69DB660", Offset = "0x69D9C60", VA = "0x1869DB660")]
		public List<Component> MPLIFDDLCJA(Type GOAECDHCJMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x69DB560", Offset = "0x69D9B60", VA = "0x1869DB560", Slot = "4")]
		public bool Equals(ToolHierarchyCache OCPDJIJPMCG, ToolHierarchyCache DEKMKLPIHFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x69DB5E0", Offset = "0x69D9BE0", VA = "0x1869DB5E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NJKKPOFFNNJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class MIJHIJGGEGD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int PLGOIBDCNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int FIIJDOPLDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private List<T> LDBHIOMIKEG;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3C094B0", Offset = "0x3C07AB0", VA = "0x183C094B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T OCFJFMFNEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x44CCF40", Offset = "0x44CB540", VA = "0x1844CCF40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T PABGCAFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x44CCE50", Offset = "0x44CB450", VA = "0x1844CCE50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T ENEELIKNLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x44CC8A0", Offset = "0x44CAEA0", VA = "0x1844CC8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x44CD0F0", Offset = "0x44CB6F0", VA = "0x1844CD0F0")]
	public MIJHIJGGEGD(int PLGOIBDCNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x44CCC70", Offset = "0x44CB270", VA = "0x1844CCC70")]
	public void LHEPNGLDBLI(T OIOMHPDOLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x44CC990", Offset = "0x44CAF90", VA = "0x1844CC990")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x44CCA00", Offset = "0x44CB000", VA = "0x1844CCA00")]
	public void IOMBLOAAPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x44CCDE0", Offset = "0x44CB3E0", VA = "0x1844CCDE0")]
	public void MCHIKHGIBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x44CC9F0", Offset = "0x44CAFF0", VA = "0x1844CC9F0")]
	public void EHMDCDDNJDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NOKBMFLBFIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct NECGLNKAILN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int DLNOMCBAPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public T FJLALGMPANI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<object, NECGLNKAILN> CJCKCFPDODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly EqualityComparer<T> GHGCKGFMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T APMLOICEBEN;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T MOMNGNDHGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA70", Offset = "0x8FA070", VA = "0x1808FBA70", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x45E17A0", Offset = "0x45DFDA0", VA = "0x1845E17A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool NPFGJKBBJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x45DDB40", Offset = "0x45DC140", VA = "0x1845DDB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object IODFPJLDNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x868240", Offset = "0x866840", VA = "0x180868240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x45DDD20", Offset = "0x45DC320", VA = "0x1845DDD20")]
	public bool IOOGOHAPAFI(T DMNGPNKHPKF, object NJLOKHEKBBE, int LOLKACMOLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x45DDBA0", Offset = "0x45DC1A0", VA = "0x1845DDBA0")]
	public bool IKNHMJKPFOG(object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x45DD2C0", Offset = "0x45DB8C0", VA = "0x1845DD2C0")]
	public bool APLEJEFPFAB(object NJLOKHEKBBE, [Out] T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x385DBE0", Offset = "0x385C1E0", VA = "0x18385DBE0")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x45E0180", Offset = "0x45DE780", VA = "0x1845E0180")]
	private bool JFKFHEKFKBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x45E1860", Offset = "0x45DFE60", VA = "0x1845E1860")]
	public NOKBMFLBFIL()
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
