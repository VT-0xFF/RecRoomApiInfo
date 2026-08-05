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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F66500", Offset = "0x7F64D00", VA = "0x187F66500")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HLHMLGINBGO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21777B0", Offset = "0x2175FB0", VA = "0x1821777B0")]
	public HLHMLGINBGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, IPGBBEOGIIF, DJFIBNFNLHL, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CEGOJJNEECN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F68A90", Offset = "0x7F67290", VA = "0x187F68A90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F68A50", Offset = "0x7F67250", VA = "0x187F68A50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F68AD0", Offset = "0x7F672D0", VA = "0x187F68AD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F68C80", Offset = "0x7F67480", VA = "0x187F68C80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F68BF0", Offset = "0x7F673F0", VA = "0x187F68BF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x11223F0", Offset = "0x1120BF0", VA = "0x1811223F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDD27A0", Offset = "0xDD0FA0", VA = "0x180DD27A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F68A10", Offset = "0x7F67210", VA = "0x187F68A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F68B60", Offset = "0x7F67360", VA = "0x187F68B60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F684B0", Offset = "0x7F66CB0", VA = "0x187F684B0")]
	public void CopyBounds(SavedExtents KEKEFPAJGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F68960", Offset = "0x7F67160", VA = "0x187F68960")]
	public void SetLocalSpaceBounds(Bounds NJFPDKDIJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1514D10", Offset = "0x1513510", VA = "0x181514D10")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F687A0", Offset = "0x7F66FA0", VA = "0x187F687A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F687B0", Offset = "0x7F66FB0", VA = "0x187F687B0")]
	private void PBBDONPHCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F685A0", Offset = "0x7F66DA0", VA = "0x187F685A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F67E70", Offset = "0x7F66670", VA = "0x187F67E70")]
	public static void CalculateLocalBoundsFor(GameObject EMOLHEPHCGI, [Out] Bounds NJFPDKDIJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F684E0", Offset = "0x7F66CE0", VA = "0x187F684E0")]
	private static void KLLGAKMAMCK(Bounds LDEEDNGKJOE, Color GJJIDOPGHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F68980", Offset = "0x7F67180", VA = "0x187F68980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x19CE970", Offset = "0x19CD170", VA = "0x1819CE970")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5AE18D0", Offset = "0x5AE00D0", VA = "0x185AE18D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public virtual void PHCEIBNPMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
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
	[HLHMLGINBGO]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1400", Offset = "0x5ADFC00", VA = "0x185AE1400", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5ADFEE0", Offset = "0x5ADE6E0", VA = "0x185ADFEE0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5AE17E0", Offset = "0x5ADFFE0", VA = "0x185AE17E0")]
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
	private sealed class PPGBDGECMEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PPGBDGECMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x58CBE40", Offset = "0x58CA640", VA = "0x1858CBE40")]
		internal int PLEABINBDMI(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[HLHMLGINBGO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4761A40", Offset = "0x4760240", VA = "0x184761A40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4761AA0", Offset = "0x47602A0", VA = "0x184761AA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4761910", Offset = "0x4760110", VA = "0x184761910", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MNMCNOJCKAF]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x47619D0", Offset = "0x47601D0", VA = "0x1847619D0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x47617B0", Offset = "0x475FFB0", VA = "0x1847617B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4761430", Offset = "0x475FC30", VA = "0x184761430", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47607A0", Offset = "0x475EFA0", VA = "0x1847607A0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4760710", Offset = "0x475EF10", VA = "0x184760710", Slot = "14")]
	protected virtual string MIFIMNOIKKB(TKeyVal BHFFIDJKCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4760600", Offset = "0x475EE00", VA = "0x184760600", Slot = "4")]
	public bool ContainsKey(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4761620", Offset = "0x475FE20", VA = "0x184761620", Slot = "5")]
	public bool TryGetValue(TKey MNMCNOJCKAF, [Out] TVal MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4760660", Offset = "0x475EE60", VA = "0x184760660", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4760660", Offset = "0x475EE60", VA = "0x184760660", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4761680", Offset = "0x475FE80", VA = "0x184761680")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
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
		[Cpp2IlInjected.Address(RVA = "0x4665B70", Offset = "0x4664370", VA = "0x184665B70")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[HLHMLGINBGO]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5AE3370", Offset = "0x5AE1B70", VA = "0x185AE3370")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2B60", Offset = "0x5AE1360", VA = "0x185AE2B60", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5AE20A0", Offset = "0x5AE08A0", VA = "0x185AE20A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class KGELOAEEFFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct IOJGDDGCGFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T HDAKFEADKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float APGBNHABJGC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int LNIOJLCNGOB = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float FJDDAEBPKNO = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly IOJGDDGCGFP[] LPBOBEPEKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int PAIOINJFMOM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float BIJNOCCHJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC9E6B0", Offset = "0xC9CEB0", VA = "0x180C9E6B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xCE1A20", Offset = "0xCE0220", VA = "0x180CE1A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T IFBGPBNHAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x51ACDA0", Offset = "0x51AB5A0", VA = "0x1851ACDA0")]
	protected KGELOAEEFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x51ACDE0", Offset = "0x51AB5E0", VA = "0x1851ACDE0")]
	protected KGELOAEEFFG(int GGIJOHIPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51ACC70", Offset = "0x51AB470", VA = "0x1851ACC70")]
	public void GGGBGBDKNKJ(float BPMPOGGBGJO, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JACEFKHEMIK(float CJPPNNPCEBH, float FHGOCKAFABF, [Out] T MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool CEPBGBAOKDA(float CJPPNNPCEBH, float FHGOCKAFABF, [Out] T MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x51ACAE0", Offset = "0x51AB2E0", VA = "0x1851ACAE0")]
	public void CGGBONADGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ANOFFDLPCJN : KGELOAEEFFG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F64DD0", Offset = "0x7F635D0", VA = "0x187F64DD0", Slot = "4")]
	public override bool JACEFKHEMIK(float CJPPNNPCEBH, float FHGOCKAFABF, [Out] Vector3 MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F64C90", Offset = "0x7F63490", VA = "0x187F64C90", Slot = "5")]
	public override bool CEPBGBAOKDA(float CJPPNNPCEBH, float FHGOCKAFABF, [Out] Vector3 MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F64F30", Offset = "0x7F63730", VA = "0x187F64F30")]
	public ANOFFDLPCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GJCAPODBJFG
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39E5850", Offset = "0x39E4050", VA = "0x1839E5850")]
	public static KGIPDLMHNNM<T1, T2> INHDMBAMCNE<T1, T2>(T1 JJJNHKNNNPG, T2 KEMCBHBHPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x39E58F0", Offset = "0x39E40F0", VA = "0x1839E58F0")]
	public static KIEBNPEKFDF<T1, T2, T3> INHDMBAMCNE<T1, T2, T3>(T1 JJJNHKNNNPG, T2 KEMCBHBHPPO, T3 BMBELBIMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5591440", Offset = "0x558FC40", VA = "0x185591440")]
	internal static int IOKDMEBMNLJ(int HBMBPLFGMCL, int FBIGNPDLADA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7162580", Offset = "0x7160D80", VA = "0x187162580")]
	internal static int IOKDMEBMNLJ(int HBMBPLFGMCL, int FBIGNPDLADA, int NPBJEACDJIH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KGIPDLMHNNM<T1, T2> : IComparable<KGIPDLMHNNM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 FLLFHALPLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 MJIKAKIHBNF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x51AEDA0", Offset = "0x51AD5A0", VA = "0x1851AEDA0")]
	public KGIPDLMHNNM(T1 JJJNHKNNNPG, T2 KEMCBHBHPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x51AD0B0", Offset = "0x51AB8B0", VA = "0x1851AD0B0", Slot = "4")]
	public int CompareTo(KGIPDLMHNNM<T1, T2> KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x51AD9A0", Offset = "0x51AC1A0", VA = "0x1851AD9A0", Slot = "0")]
	public override bool Equals(object KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x51AE150", Offset = "0x51AC950", VA = "0x1851AE150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x51AE990", Offset = "0x51AD190", VA = "0x1851AE990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KIEBNPEKFDF<T1, T2, T3> : IComparable<KIEBNPEKFDF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 FLLFHALPLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 MJIKAKIHBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 LCMJDKBHKAO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x51B77B0", Offset = "0x51B5FB0", VA = "0x1851B77B0")]
	public KIEBNPEKFDF(T1 JJJNHKNNNPG, T2 KEMCBHBHPPO, T3 BMBELBIMALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x51B6F70", Offset = "0x51B5770", VA = "0x1851B6F70", Slot = "4")]
	public int CompareTo(KIEBNPEKFDF<T1, T2, T3> KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x51B70D0", Offset = "0x51B58D0", VA = "0x1851B70D0", Slot = "0")]
	public override bool Equals(object KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x51B73B0", Offset = "0x51B5BB0", VA = "0x1851B73B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x51B74E0", Offset = "0x51B5CE0", VA = "0x1851B74E0", Slot = "3")]
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
	public AnimationCurve LOEEJFDPCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T AELBMNNHFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x139CFD0", Offset = "0x139B7D0", VA = "0x18139CFD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T NAOFEDIDLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AD10", Offset = "0x2C99510", VA = "0x182C9AD10")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AC20", Offset = "0x2C99420", VA = "0x182C9AC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FHNLEBKAPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC86040", Offset = "0xC84840", VA = "0x180C86040")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5B90", Offset = "0x5DB4390", VA = "0x185DB5B90")]
	public T BMENPNAAIIH(float ODKLOJBBLOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5F30", Offset = "0x5DB4730", VA = "0x185DB5F30")]
	public T DKABGLPFPAN(float ODKLOJBBLOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LHPIEEGKDHD(T NOGJAHKGFJD, T LHMEHOJLNDH, float ODKLOJBBLOI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F65840", Offset = "0x7F64040", VA = "0x187F65840", Slot = "4")]
	protected override float LHPIEEGKDHD(float NOGJAHKGFJD, float LHMEHOJLNDH, float ODKLOJBBLOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F65880", Offset = "0x7F64080", VA = "0x187F65880")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1809A70", Offset = "0x1808270", VA = "0x181809A70", Slot = "4")]
	protected override Vector3 LHPIEEGKDHD(Vector3 NOGJAHKGFJD, Vector3 LHMEHOJLNDH, float ODKLOJBBLOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F69A80", Offset = "0x7F68280", VA = "0x187F69A80")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F653B0", Offset = "0x7F63BB0", VA = "0x187F653B0", Slot = "4")]
	protected override Color LHPIEEGKDHD(Color NOGJAHKGFJD, Color LHMEHOJLNDH, float ODKLOJBBLOI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F65470", Offset = "0x7F63C70", VA = "0x187F65470")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EMJMKMABGFM : PJHONLFLALK<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F657F0", Offset = "0x7F63FF0", VA = "0x187F657F0")]
	public EMJMKMABGFM(int BEMGFNOEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F65780", Offset = "0x7F63F80", VA = "0x187F65780", Slot = "6")]
	protected override uint LJIIGHICIHJ(uint CEGOJJNEECN, string MGONBEDEDON)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DDEIEPONECO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable HPECEAELCLK;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DDEIEPONECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ALMKPIKJFNG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PHMGMHPPFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LLBDEONOLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int LMLPLIFMKCO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4C854E0", Offset = "0x4C83CE0", VA = "0x184C854E0")]
	private ALMKPIKJFNG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JLFLDGDCOGF, int LLFBNPLBBAH, int DPIIAJNIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E32110", Offset = "0x4E30910", VA = "0x184E32110")]
	public static ALMKPIKJFNG<T> CCPKJDCALBG()
	{
		return default(ALMKPIKJFNG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E330E0", Offset = "0x4E318E0", VA = "0x184E330E0")]
	public (int, int, Task<T>) NAEMIPJMCCL(int LFGOLEKPJOL, [Optional] CancellationToken GMEAHOBHMAD, double AFBFHAPCPPE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E31CD0", Offset = "0x4E304D0", VA = "0x184E31CD0")]
	public void AKGEMGMKGPD(int LFGOLEKPJOL, int DPIIAJNIKCJ, [In] T KJCFPPKBAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EFJKAMKGLBB
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F65730", Offset = "0x7F63F30", VA = "0x187F65730")]
	public static ALMKPIKJFNG<KCHLBHAFJKA> CCPKJDCALBG()
	{
		return default(ALMKPIKJFNG<KCHLBHAFJKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F656B0", Offset = "0x7F63EB0", VA = "0x187F656B0")]
	public static void AKGEMGMKGPD([In] this ALMKPIKJFNG<KCHLBHAFJKA> DKBBJFIDEGB, int LFGOLEKPJOL, int DPIIAJNIKCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class LKJNPHDICNA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> FJFIDMEAMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> CAMIFMICHNM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4253080", Offset = "0x4251880", VA = "0x184253080", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FEDAMJDDKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> MDFMDLBAKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x51B03E0", Offset = "0x51AEBE0", VA = "0x1851B03E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> AOPGOIANMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4E7E570", Offset = "0x4E7CD70", VA = "0x184E7E570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5306260", Offset = "0x5304A60", VA = "0x185306260", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5306370", Offset = "0x5304B70", VA = "0x185306370", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5305DF0", Offset = "0x53045F0", VA = "0x185305DF0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x53058E0", Offset = "0x53040E0", VA = "0x1853058E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5306080", Offset = "0x5304880", VA = "0x185306080", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5305480", Offset = "0x5303C80", VA = "0x185305480", Slot = "9")]
	public void Add(TKey MNMCNOJCKAF, TVal MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x53053F0", Offset = "0x5303BF0", VA = "0x1853053F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5305990", Offset = "0x5304190", VA = "0x185305990", Slot = "8")]
	public bool ContainsKey(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5305A30", Offset = "0x5304230", VA = "0x185305A30", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5305F70", Offset = "0x5304770", VA = "0x185305F70", Slot = "10")]
	public bool Remove(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5305FF0", Offset = "0x53047F0", VA = "0x185305FF0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x53060D0", Offset = "0x53048D0", VA = "0x1853060D0", Slot = "11")]
	public bool TryGetValue(TKey MNMCNOJCKAF, [Out] TVal MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5305D50", Offset = "0x5304550", VA = "0x185305D50", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5305A70", Offset = "0x5304270", VA = "0x185305A70", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LPBOBEPEKNH, int LJDJNPPCHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5305F10", Offset = "0x5304710", VA = "0x185305F10")]
	public bool PLBNMDLFKAN(TVal MNMCNOJCKAF, [Out] TKey MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5305600", Offset = "0x5303E00", VA = "0x185305600")]
	private void BFNDKMOBGPL(TKey MNMCNOJCKAF, TVal AMJBMFFPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5305700", Offset = "0x5303F00", VA = "0x185305700")]
	private void CBEBPGFFEMH(TKey MNMCNOJCKAF, TVal AMJBMFFPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5305C20", Offset = "0x5304420", VA = "0x185305C20")]
	private bool FOCGCKAPFDH(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5306130", Offset = "0x5304930", VA = "0x185306130")]
	public LKJNPHDICNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class IIONIJMNFJC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IIONIJMNFJC<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x136EB20", Offset = "0x136D320", VA = "0x18136EB20", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x47CB810", Offset = "0x47CA010", VA = "0x1847CB810", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x47CCE60", Offset = "0x47CB660", VA = "0x1847CCE60")]
		public Enumerator(IIONIJMNFJC<T> FLHFCEEIHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x47C9FF0", Offset = "0x47C87F0", VA = "0x1847C9FF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x47CADF0", Offset = "0x47C95F0", VA = "0x1847CADF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x47C98A0", Offset = "0x47C80A0", VA = "0x1847C98A0")]
		private void KKEGKBFMMCA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] GDNAPNPEGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int COEFDMIBPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int NDAODLEBNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int EHCBHNLMEHF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DE80", Offset = "0x4E7C680", VA = "0x184E7DE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4E7E0E0", Offset = "0x4E7C8E0", VA = "0x184E7E0E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DC00", Offset = "0x4E7C400", VA = "0x184E7DC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E4D0", Offset = "0x4E7CCD0", VA = "0x184E7E4D0")]
	public IIONIJMNFJC(int BEMGFNOEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C7E0", Offset = "0x4E7AFE0", VA = "0x184E7C7E0")]
	public void GGGBGBDKNKJ(T ODKLOJBBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C1C0", Offset = "0x4E7A9C0", VA = "0x184E7C1C0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C1E0", Offset = "0x4E7A9E0", VA = "0x184E7C1E0")]
	public void GBEDIIKBJIG(int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CD90", Offset = "0x4E7B590", VA = "0x184E7CD90")]
	public void HBCBFICEHBC(T[] LPBOBEPEKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4E7DA00", Offset = "0x4E7C200", VA = "0x184E7DA00")]
	public Enumerator KFPOPIJHFBP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E420", Offset = "0x4E7CC20", VA = "0x184E7E420", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E420", Offset = "0x4E7CC20", VA = "0x184E7E420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D490", Offset = "0x4E7BC90", VA = "0x184E7D490")]
	private int HHIBCBLIFBG(int PNJCJGEIDHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D990", Offset = "0x4E7C190", VA = "0x184E7D990")]
	private int JDGBIIBHICK(int PNJCJGEIDHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ONELANNAINO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> NDGJGHMIKDH(TRequest FLPDPHNPDPK, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum JBCGIIGPOHC
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ELMNCIFPABH
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float ACELOGEHBML = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan BFELGLCBGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int NDNPIAPMLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JBCGIIGPOHC DBELIKHAINK;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly ELMNCIFPABH JMOEBDABFID;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float KMAMGFPGPLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x473C380", Offset = "0x473AB80", VA = "0x18473C380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan AOCBNNKLPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x473C460", Offset = "0x473AC60", VA = "0x18473C460")]
		public ELMNCIFPABH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct JKDBHKADKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest FLPDPHNPDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken GMEAHOBHMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> LIGCMJIBDEP;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x50C1F70", Offset = "0x50C0770", VA = "0x1850C1F70")]
		public JKDBHKADKAP(TRequest FLPDPHNPDPK, TaskCompletionSource<TResult> LIGCMJIBDEP, CancellationToken GMEAHOBHMAD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct OBFLODEEOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public ONELANNAINO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x571C9E0", Offset = "0x571B1E0", VA = "0x18571C9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x571CE50", Offset = "0x571B650", VA = "0x18571CE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct EOOEEIGMNNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ONELANNAINO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private JKDBHKADKAP <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4753850", Offset = "0x4752050", VA = "0x184753850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4753E60", Offset = "0x4752660", VA = "0x184753E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource HADFNMGGLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<JKDBHKADKAP> LKFAEICLOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly ELMNCIFPABH HIPICOFCEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly NDGJGHMIKDH FKKNPKNNCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task HEJLKOOGPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int NIIFKIMKFIC;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5755CA0", Offset = "0x57544A0", VA = "0x185755CA0")]
	public ONELANNAINO(NDGJGHMIKDH FKKNPKNNCFH, [Optional] ELMNCIFPABH HIPICOFCEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x57558D0", Offset = "0x57540D0", VA = "0x1857558D0")]
	public Task<TResult> JAFNPIOLEAD(TRequest FLPDPHNPDPK, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5754CA0", Offset = "0x57534A0", VA = "0x185754CA0")]
	private void FIDDLIHEHAP(JKDBHKADKAP HCFENCAGPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5755330", Offset = "0x5753B30", VA = "0x185755330")]
	[AsyncStateMachine(typeof(ONELANNAINO<, >.OBFLODEEOJL))]
	private Task IPLFPEGKOEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5753FB0", Offset = "0x57527B0", VA = "0x185753FB0")]
	private JKDBHKADKAP CKOPOJDFBNF()
	{
		return default(JKDBHKADKAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x57549E0", Offset = "0x57531E0", VA = "0x1857549E0")]
	[AsyncStateMachine(typeof(ONELANNAINO<, >.EOOEEIGMNNL))]
	private Task EKHPOFMIAFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5754E60", Offset = "0x5753660", VA = "0x185754E60")]
	private void FJFBGDIKEJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x57548B0", Offset = "0x57530B0", VA = "0x1857548B0", Slot = "4")]
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
public class IFDONEBMAGD<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> NFJJCCDFOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> IFMPNEMKHOA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4253080", Offset = "0x4251880", VA = "0x184253080", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FEDAMJDDKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3BDC6C0", Offset = "0x3BDAEC0", VA = "0x183BDC6C0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E72980", Offset = "0x4E71180", VA = "0x184E72980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF520", Offset = "0x4BDDD20", VA = "0x184BDF520", Slot = "11")]
	public void Add(T NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E71B80", Offset = "0x4E70380", VA = "0x184E71B80")]
	public bool CGCACJNCGGH(T NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E72630", Offset = "0x4E70E30", VA = "0x184E72630", Slot = "15")]
	public bool Remove(T NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4E71F10", Offset = "0x4E70710", VA = "0x184E71F10", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4C29760", Offset = "0x4C27F60", VA = "0x184C29760", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E71DA0", Offset = "0x4E705A0", VA = "0x184E71DA0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E71E50", Offset = "0x4E70650", VA = "0x184E71E50", Slot = "13")]
	public bool Contains(T NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E71EB0", Offset = "0x4E706B0", VA = "0x184E71EB0", Slot = "14")]
	public void CopyTo(T[] LPBOBEPEKNH, int LJDJNPPCHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E71FA0", Offset = "0x4E707A0", VA = "0x184E71FA0", Slot = "6")]
	public int IndexOf(T NAGJHHJDFPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E72150", Offset = "0x4E70950", VA = "0x184E72150", Slot = "7")]
	public void Insert(int PNJCJGEIDHG, T NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E722A0", Offset = "0x4E70AA0", VA = "0x184E722A0", Slot = "8")]
	public void RemoveAt(int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E72700", Offset = "0x4E70F00", VA = "0x184E72700")]
	public IFDONEBMAGD()
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
			[Cpp2IlInjected.Address(RVA = "0x2AF41C0", Offset = "0x2AF29C0", VA = "0x182AF41C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F69020", Offset = "0x7F67820", VA = "0x187F69020")]
		public SerializedGuid([In] Guid JMHOEKKPCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F68D10", Offset = "0x7F67510", VA = "0x187F68D10")]
		public static SerializedGuid CKFHIIIMAAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F68F00", Offset = "0x7F67700", VA = "0x187F68F00")]
		public static SerializedGuid LMEILILBBGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F68EA0", Offset = "0x7F676A0", VA = "0x187F68EA0")]
		public bool KBMDKILMFNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F68FF0", Offset = "0x7F677F0", VA = "0x187F68FF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F68F70", Offset = "0x7F67770", VA = "0x187F68F70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F68DC0", Offset = "0x7F675C0", VA = "0x187F68DC0", Slot = "7")]
		public bool Equals(SerializedGuid KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F68E00", Offset = "0x7F67600", VA = "0x187F68E00", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F68E90", Offset = "0x7F67690", VA = "0x187F68E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F68D90", Offset = "0x7F67590", VA = "0x187F68D90", Slot = "6")]
		public int CompareTo(SerializedGuid KEKEFPAJGHD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EAELFFPFKGO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type BAFAHNMINML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string COLJEPLKIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool ANJCBPOBKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool FDPMADDLMBO;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F65640", Offset = "0x7F63E40", VA = "0x187F65640")]
	public EAELFFPFKGO(Type FEGAFNNCBON, string HAACJGDEIAM, bool OHBKIGLDBKM = false, bool MKKNDHACJBD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BAADDCGGBIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int MCKHDIPCFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> BHLONOGOBGC(float BPMPOGGBGJO, [Optional] float? BEGJAHPMOEF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MFCKKNKFIAK(float BPMPOGGBGJO, T MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGGBONADGHB();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class JBGIHOEMMLJ<T> : BAADDCGGBIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class OFFNLMMBMEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float KFGDBBGOMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T HDAKFEADKFH;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OFFNLMMBMEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AKLBPAOAGDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AKLBPAOAGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4E2FFB0", Offset = "0x4E2E7B0", VA = "0x184E2FFB0")]
		internal bool OCPBLNOIMKF(OFFNLMMBMEL sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float KNNLCJBMIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float MOFOCJBKPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<OFFNLMMBMEL> PFJNGBMMPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private DMJNBPOKINC<OFFNLMMBMEL> DCMBGBIMNIM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MCKHDIPCFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5086F80", Offset = "0x5085780", VA = "0x185086F80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5087060", Offset = "0x5085860", VA = "0x185087060")]
	public JBGIHOEMMLJ(float GPMILGMDJMB, float EDMPCNDMBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x50869F0", Offset = "0x50851F0", VA = "0x1850869F0", Slot = "6")]
	public bool MFCKKNKFIAK(float BPMPOGGBGJO, T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5086590", Offset = "0x5084D90", VA = "0x185086590", Slot = "5")]
	public IEnumerable<T> BHLONOGOBGC(float BPMPOGGBGJO, float? BEGJAHPMOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5086930", Offset = "0x5085130", VA = "0x185086930", Slot = "7")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5086DC0", Offset = "0x50855C0", VA = "0x185086DC0")]
	private void OBCHBDEKJFC(float BPMPOGGBGJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class JBOBIMOIFEL<T> : BAADDCGGBIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct HMFKDDHDBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T HDAKFEADKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float KFGDBBGOMHE;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4D25AB0", Offset = "0x4D242B0", VA = "0x184D25AB0")]
		public HMFKDDHDBCG(T MGONBEDEDON, float BPMPOGGBGJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IJEEJFBFGHG : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public JBOBIMOIFEL<T> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public IJEEJFBFGHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4E82FF0", Offset = "0x4E817F0", VA = "0x184E82FF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4E833D0", Offset = "0x4E81BD0", VA = "0x184E833D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4E831C0", Offset = "0x4E819C0", VA = "0x184E831C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C653A0", Offset = "0x4C63BA0", VA = "0x184C653A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float GPMILGMDJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float EDMPCNDMBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<HMFKDDHDBCG> PFJNGBMMPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int COEFDMIBPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int FKAIKGJPBGN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int MCKHDIPCFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x508D040", Offset = "0x508B840", VA = "0x18508D040")]
	public JBOBIMOIFEL(float GPMILGMDJMB, float EDMPCNDMBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x508CD50", Offset = "0x508B550", VA = "0x18508CD50", Slot = "6")]
	public bool MFCKKNKFIAK(float BPMPOGGBGJO, T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x508C640", Offset = "0x508AE40", VA = "0x18508C640", Slot = "8")]
	public int BIMIOEFEJJK(float BPMPOGGBGJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x508C4A0", Offset = "0x508ACA0", VA = "0x18508C4A0", Slot = "5")]
	[IteratorStateMachine(typeof(JBOBIMOIFEL<>.IJEEJFBFGHG))]
	public IEnumerable<T> BHLONOGOBGC(float BPMPOGGBGJO, float? BEGJAHPMOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x508C690", Offset = "0x508AE90", VA = "0x18508C690", Slot = "7")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x508C6F0", Offset = "0x508AEF0", VA = "0x18508C6F0")]
	private void CJAJBMGLPFH(float BPMPOGGBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x508C9A0", Offset = "0x508B1A0", VA = "0x18508C9A0")]
	private HMFKDDHDBCG HPMPJHOHOGM()
	{
		return default(HMFKDDHDBCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DKKFAAJNJJM<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct CADAAHGNIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long MPMGKJIPPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long LKCOJPPKPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int AGBBDCCHLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int GAPBOANDGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool ALFHJCOILDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string CMIHEECOJLK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x65A9690", Offset = "0x65A7E90", VA = "0x1865A9690")]
		public CADAAHGNIJM(long MPMGKJIPPKE, int AGBBDCCHLEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x65A9700", Offset = "0x65A7F00", VA = "0x1865A9700")]
		public CADAAHGNIJM(long MPMGKJIPPKE, long LKCOJPPKPDL, int AGBBDCCHLEO, int GAPBOANDGAI, bool ALFHJCOILDI, string CMIHEECOJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x65A9580", Offset = "0x65A7D80", VA = "0x1865A9580")]
		public int BALKKDMICEH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x65A95D0", Offset = "0x65A7DD0", VA = "0x1865A95D0")]
		public int CDLGICIIDHP(int GCHINKNILIJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x65A9520", Offset = "0x65A7D20", VA = "0x1865A9520")]
		public double AJAJHNJEIPE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x65A95F0", Offset = "0x65A7DF0", VA = "0x1865A95F0")]
		public CADAAHGNIJM OILMDPDCFBB(long LKCOJPPKPDL, int GAPBOANDGAI)
		{
			return default(CADAAHGNIJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class BNLIHIFJPDL : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct BCJIFACHJBP<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public BNLIHIFJPDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<BNLIHIFJPDL, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private BNLIHIFJPDL <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6162EF0", Offset = "0x61616F0", VA = "0x186162EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4CA7710", Offset = "0x4CA5F10", VA = "0x184CA7710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey IIACIMCDNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly DKKFAAJNJJM<TKey> PFLKFIDCFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly BMELPJIFPCL GLHOMCPEEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<BNLIHIFJPDL> CNANOCPNGFK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string ILENCIPDGLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5264570", Offset = "0x5262D70", VA = "0x185264570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<BNLIHIFJPDL> FGPCCDOIGEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6276950", Offset = "0x6275150", VA = "0x186276950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public CADAAHGNIJM KIIPFIPPCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x62766D0", Offset = "0x6274ED0", VA = "0x1862766D0")]
			[CompilerGenerated]
			get
			{
				return default(CADAAHGNIJM);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6276990", Offset = "0x6275190", VA = "0x186276990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6276B80", Offset = "0x6275380", VA = "0x186276B80")]
		internal BNLIHIFJPDL(DKKFAAJNJJM<TKey> PFLKFIDCFJL, TKey MNMCNOJCKAF, BMELPJIFPCL GLHOMCPEEHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62769C0", Offset = "0x62751C0", VA = "0x1862769C0")]
		public BNLIHIFJPDL NBLPLODNPED(TKey MNMCNOJCKAF, [Optional] BMELPJIFPCL? FPOOCCKKELD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD4200", Offset = "0x3BD2A00", VA = "0x183BD4200")]
		[AsyncStateMachine(typeof(BCJIFACHJBP<>))]
		public Task<T> GKHBHBHLIAD<T>(TKey MNMCNOJCKAF, Func<BNLIHIFJPDL, Task<T>> OHENIKPHLCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x62766F0", Offset = "0x6274EF0", VA = "0x1862766F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FFGGKBDPCPD : IEnumerable<(TKey, List<TKey>, CADAAHGNIJM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CADAAHGNIJM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, CADAAHGNIJM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DKKFAAJNJJM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, CADAAHGNIJM timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, CADAAHGNIJM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2AEEE80", Offset = "0x2AED680", VA = "0x182AEEE80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CADAAHGNIJM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4BA9BA0", Offset = "0x4BA83A0", VA = "0x184BA9BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEF70", Offset = "0x2AED770", VA = "0x182AEEF70")]
		[DebuggerHidden]
		public FFGGKBDPCPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9C00", Offset = "0x4BA8400", VA = "0x184BA9C00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9680", Offset = "0x4BA7E80", VA = "0x184BA9680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9630", Offset = "0x4BA7E30", VA = "0x184BA9630")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9B50", Offset = "0x4BA8350", VA = "0x184BA9B50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9A30", Offset = "0x4BA8230", VA = "0x184BA9A30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CADAAHGNIJM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9B10", Offset = "0x4BA8310", VA = "0x184BA9B10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IKDAFFJDFAP : IEnumerable<(TKey, List<TKey>, CADAAHGNIJM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CADAAHGNIJM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, CADAAHGNIJM timerEntry) <>2__current;

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
		private BNLIHIFJPDL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public BNLIHIFJPDL <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public DKKFAAJNJJM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<BNLIHIFJPDL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, CADAAHGNIJM timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, CADAAHGNIJM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2AEEE80", Offset = "0x2AED680", VA = "0x182AEEE80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CADAAHGNIJM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4E89100", Offset = "0x4E87900", VA = "0x184E89100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEF70", Offset = "0x2AED770", VA = "0x182AEEF70")]
		[DebuggerHidden]
		public IKDAFFJDFAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4E89160", Offset = "0x4E87960", VA = "0x184E89160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4E88790", Offset = "0x4E86F90", VA = "0x184E88790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4E88730", Offset = "0x4E86F30", VA = "0x184E88730")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4E886D0", Offset = "0x4E86ED0", VA = "0x184E886D0")]
		private void CLFKDHFELPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4E890B0", Offset = "0x4E878B0", VA = "0x184E890B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4E88F70", Offset = "0x4E87770", VA = "0x184E88F70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CADAAHGNIJM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4E89070", Offset = "0x4E87870", VA = "0x184E89070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, CADAAHGNIJM, BMELPJIFPCL> KAAAKOPOEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, CADAAHGNIJM, BMELPJIFPCL> BDNECIOIDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<DKKFAAJNJJM<TKey>, BMELPJIFPCL> OPOPNAPENKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly BNLIHIFJPDL BIJGHCLELHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool DMJNBPLABAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int PHPHADNBDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch GBIMFNJHIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int DHPCMBEJJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string MJMKOLEBNDE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BNLIHIFJPDL LHFMICHKPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string ILENCIPDGLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D2C0", Offset = "0x6D4BAC0", VA = "0x186D4D2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D4D4C0", Offset = "0x6D4BCC0", VA = "0x186D4D4C0")]
	public DKKFAAJNJJM(TKey MAFNKPEDGAP, BMELPJIFPCL GLHOMCPEEHH, [Optional] int? AGBBDCCHLEO, [Optional][CanBeNull] Stopwatch GBIMFNJHIBO, [Optional] Action<TKey, CADAAHGNIJM, BMELPJIFPCL> KAAAKOPOEHD, [Optional] Action<TKey, CADAAHGNIJM, BMELPJIFPCL> BDNECIOIDFC, [Optional] Action<DKKFAAJNJJM<TKey>, BMELPJIFPCL> OPOPNAPENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D4D1E0", Offset = "0x6D4B9E0", VA = "0x186D4D1E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D4D320", Offset = "0x6D4BB20", VA = "0x186D4D320")]
	[IteratorStateMachine(typeof(DKKFAAJNJJM<>.FFGGKBDPCPD))]
	public IEnumerable<(TKey, List<TKey>, CADAAHGNIJM)> KMMPJKJGBDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D4D3D0", Offset = "0x6D4BBD0", VA = "0x186D4D3D0")]
	[IteratorStateMachine(typeof(DKKFAAJNJJM<>.IKDAFFJDFAP))]
	private IEnumerable<(TKey, List<TKey>, CADAAHGNIJM)> KMMPJKJGBDG(List<TKey> KBIHAKCHLAI, BNLIHIFJPDL FKOJDFELNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D4D160", Offset = "0x6D4B960", VA = "0x186D4D160")]
	private (long, int) CEAPMEMIGGD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class BENFGKBJNKN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut LPMFMGGMOEL(DKKFAAJNJJM<TKey> PFLKFIDCFJL);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected BENFGKBJNKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class CMANANGDPGD<TKey> : BENFGKBJNKN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string EPFPHPAJNOO(TKey MNMCNOJCKAF);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x67988C0", Offset = "0x67970C0", VA = "0x1867988C0")]
	private static string LCKGBBEONFB(TKey MNMCNOJCKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6798A60", Offset = "0x6797260", VA = "0x186798A60", Slot = "4")]
	public override string LPMFMGGMOEL(DKKFAAJNJJM<TKey> PFLKFIDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6798900", Offset = "0x6797100", VA = "0x186798900")]
	public string LPMFMGGMOEL(DKKFAAJNJJM<TKey> PFLKFIDCFJL, [NotNull] EPFPHPAJNOO PGPOPBPPALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string MKKPHBAOGNB(DKKFAAJNJJM<TKey> PFLKFIDCFJL, [NotNull] EPFPHPAJNOO PGPOPBPPALF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE830", Offset = "0x4BAD030", VA = "0x184BAE830")]
	protected CMANANGDPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class MINDLFPFEDA<TKey> : BENFGKBJNKN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string AGNHDAKNEHC(TKey MNMCNOJCKAF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string MABNOEMDHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double MJMFAIDKCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool PIJHKBDCFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int FJGBBCKMKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> NPCHCMAKAEP;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5544870", Offset = "0x5543070", VA = "0x185544870")]
	private static string LCKGBBEONFB(TKey MNMCNOJCKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55450C0", Offset = "0x55438C0", VA = "0x1855450C0")]
	public MINDLFPFEDA(string MABNOEMDHKC = "F2", double MJMFAIDKCLA = double.MaxValue, bool PIJHKBDCFLA = false, int FJGBBCKMKOK = int.MaxValue, [Optional] ISet<string> NPCHCMAKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x55448B0", Offset = "0x55430B0", VA = "0x1855448B0", Slot = "4")]
	public override Dictionary<string, string> LPMFMGGMOEL(DKKFAAJNJJM<TKey> PFLKFIDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5544FF0", Offset = "0x55437F0", VA = "0x185544FF0")]
	private bool NLNLJFKPJLC(string KEMJONOOJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x55449A0", Offset = "0x55431A0", VA = "0x1855449A0")]
	public Dictionary<string, string> LPMFMGGMOEL(DKKFAAJNJJM<TKey> PFLKFIDCFJL, AGNHDAKNEHC PGPOPBPPALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5544490", Offset = "0x5542C90", VA = "0x185544490")]
	private string DLCHBHKBKFF(StringBuilder HLKMFMNHBCK, List<TKey> LCIHOHAHJPC, AGNHDAKNEHC PGPOPBPPALF, bool CEBIBPGGGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5544710", Offset = "0x5542F10", VA = "0x185544710")]
	private static void ICMBFEGMPOH(StringBuilder PGCMFLMAIPJ, string BEIMFHDDPEE, bool IEKOFMCPPKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class JMNIDPOJFOA<TKey> : CMANANGDPGD<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FAKDLLFDION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public EPFPHPAJNOO keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static JMNIDPOJFOA<TKey> HPECEAELCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] GFMLJDPPHDO;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x50DBEA0", Offset = "0x50DA6A0", VA = "0x1850DBEA0")]
	private JMNIDPOJFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x50DAF20", Offset = "0x50D9720", VA = "0x1850DAF20", Slot = "5")]
	protected override string MKKPHBAOGNB(DKKFAAJNJJM<TKey> PFLKFIDCFJL, EPFPHPAJNOO PGPOPBPPALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x50DAE10", Offset = "0x50D9610", VA = "0x1850DAE10")]
	[CompilerGenerated]
	internal static string GPEBNKPGCLJ(string MCHKMAPJGLC, TKey MNMCNOJCKAF, FAKDLLFDION P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class OOOIBDPNCAF : DKKFAAJNJJM<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BDLNMFKHLLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<OOOIBDPNCAF, BMELPJIFPCL> callback;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BDLNMFKHLLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7F64F70", Offset = "0x7F63770", VA = "0x187F64F70")]
		internal void IEFLDGJJDFG(DKKFAAJNJJM<string> timer, BMELPJIFPCL log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F677F0", Offset = "0x7F65FF0", VA = "0x187F677F0")]
	public OOOIBDPNCAF(BMELPJIFPCL GLHOMCPEEHH, [Optional] string BCGEPAJNGPD, [Optional] int? AGBBDCCHLEO, [Optional] Stopwatch GBIMFNJHIBO, [Optional] Action<string, CADAAHGNIJM, BMELPJIFPCL> KAAAKOPOEHD, [Optional] Action<string, CADAAHGNIJM, BMELPJIFPCL> BDNECIOIDFC, [Optional] Action<OOOIBDPNCAF, BMELPJIFPCL> OPOPNAPENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7F67730", Offset = "0x7F65F30", VA = "0x187F67730")]
	private static Action<DKKFAAJNJJM<string>, BMELPJIFPCL> KBBDEOFNMDF(Action<OOOIBDPNCAF, BMELPJIFPCL> LKHIOLGKDDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class CLOBKKEMFMC
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class AFDJNCLEJGE : CLOBKKEMFMC
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static CLOBKKEMFMC HPECEAELCLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7F64B50", Offset = "0x7F63350", VA = "0x187F64B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float GGCAPGOHMBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x12459B0", Offset = "0x12441B0", VA = "0x1812459B0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7F64C40", Offset = "0x7F63440", VA = "0x187F64C40")]
		public AFDJNCLEJGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static CLOBKKEMFMC EIKACDMFGDJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static CLOBKKEMFMC JMOEBDABFID
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7F65250", Offset = "0x7F63A50", VA = "0x187F65250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float GGCAPGOHMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected CLOBKKEMFMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CJHHFDGDDDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool JNLECKPDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OBKOLGEFKBC<T> : CJHHFDGDDDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> HINMCAAKHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	BFIFKPBFBML<T> ABKCGBMDPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GOGKLANEADO
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x39E9650", Offset = "0x39E7E50", VA = "0x1839E9650")]
	public static OBKOLGEFKBC<TResource> MMPCFPIJMKJ<TResource, TId>(this FLKAIJPABOG<TId, TResource> LPHLJKPCIAD, TId EBHOIBHGECB, [Optional] Func<TId, CancellationToken, Task<TResource>>? PKAOCDEJGPO) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class FEKFCJKEJMA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BEAKGGCJKLI<T> : HHNPEBFGDLG<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> HINMCAAKHDM
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override BFIFKPBFBML<T?> ABKCGBMDPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x61675C0", Offset = "0x6165DC0", VA = "0x1861675C0")]
		public BEAKGGCJKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "10")]
		protected override void CLFGCPOKFOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class OFDDMOJMCNM<T> : HHNPEBFGDLG<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T CAHHLOMINPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? EHGLJKCKFLA;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> HINMCAAKHDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override BFIFKPBFBML<T> ABKCGBMDPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5729ED0", Offset = "0x57286D0", VA = "0x185729ED0")]
		public OFDDMOJMCNM(T IIDHOGPKICC, Action<T>? FGPNMBDMFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5729CD0", Offset = "0x57284D0", VA = "0x185729CD0", Slot = "10")]
		protected override void CLFGCPOKFOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class GIKJANFMFHH<T> : HHNPEBFGDLG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> HINMCAAKHDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override BFIFKPBFBML<T> ABKCGBMDPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4C8C0B0", Offset = "0x4C8A8B0", VA = "0x184C8C0B0")]
		public GIKJANFMFHH(Exception PAPMAHJECNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "10")]
		protected override void CLFGCPOKFOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class DPJOLJIDDNJ<T> : HHNPEBFGDLG<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct FKHDKGIHKDO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<OBKOLGEFKBC<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<OBKOLGEFKBC<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4BB3410", Offset = "0x4BB1C10", VA = "0x184BB3410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4BB3950", Offset = "0x4BB2150", VA = "0x184BB3950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct OGGCHALALFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<OBKOLGEFKBC<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<OBKOLGEFKBC<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x572F740", Offset = "0x572DF40", VA = "0x18572F740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x572FBC0", Offset = "0x572E3C0", VA = "0x18572FBC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<OBKOLGEFKBC<T>> HHDIHMKNACN;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> HINMCAAKHDM
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override BFIFKPBFBML<T> ABKCGBMDPJE
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6D65470", Offset = "0x6D63C70", VA = "0x186D65470")]
		public DPJOLJIDDNJ(Task<OBKOLGEFKBC<T>> FEGBHCAEMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6D64F00", Offset = "0x6D63700", VA = "0x186D64F00", Slot = "10")]
		protected override void CLFGCPOKFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6D65170", Offset = "0x6D63970", VA = "0x186D65170")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(DPJOLJIDDNJ<>.FKHDKGIHKDO))]
		internal static Task<T> IJFEJPOGCFD(Task<OBKOLGEFKBC<T>> FEGBHCAEMDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6D64F90", Offset = "0x6D63790", VA = "0x186D64F90")]
		[AsyncStateMachine(typeof(DPJOLJIDDNJ<>.OGGCHALALFP))]
		[CompilerGenerated]
		internal static Task EPHAPLKFPHI(Task<OBKOLGEFKBC<T>> FEGBHCAEMDO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class OKAJMALHNJB<TIn, TOut> : HHNPEBFGDLG<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct HGEPHPLDKFB : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x4D035E0", Offset = "0x4D01DE0", VA = "0x184D035E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4BAB110", Offset = "0x4BA9910", VA = "0x184BAB110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly OBKOLGEFKBC<TIn> DOIGFLKKFHC;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> HINMCAAKHDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override BFIFKPBFBML<TOut> ABKCGBMDPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x57421C0", Offset = "0x57409C0", VA = "0x1857421C0")]
		public OKAJMALHNJB(OBKOLGEFKBC<TIn> BGFEEBAGKDO, Func<TIn, TOut> EIJALANKPLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5741E00", Offset = "0x5740600", VA = "0x185741E00", Slot = "10")]
		protected override void CLFGCPOKFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5741EA0", Offset = "0x57406A0", VA = "0x185741EA0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(OKAJMALHNJB<, >.HGEPHPLDKFB))]
		internal static Task<TOut> KGIBHCIEFNP(Task<TIn> LFLEFAMICOB, Func<TIn, TOut> EIJALANKPLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x39A8A30", Offset = "0x39A7230", VA = "0x1839A8A30")]
	public static OBKOLGEFKBC<T> EBKBGKJDDBM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x39A8AB0", Offset = "0x39A72B0", VA = "0x1839A8AB0")]
	public static OBKOLGEFKBC<T> KIFMLBHPBIB<T>(T KJCFPPKBAOB, [Optional] Action<T>? FGPNMBDMFMD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3845120", Offset = "0x3843920", VA = "0x183845120")]
	public static OBKOLGEFKBC<T> KFNADKPLPFG<T>(Exception PAPMAHJECNB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3845120", Offset = "0x3843920", VA = "0x183845120")]
	public static OBKOLGEFKBC<T> FGLIMMFGDJA<T>(Task<OBKOLGEFKBC<T>> FEGBHCAEMDO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x372D440", Offset = "0x372BC40", VA = "0x18372D440")]
	public static OBKOLGEFKBC<TOut> GNOACPCNCKE<TOut, TIn>(OBKOLGEFKBC<TIn> DAMJGGDGMEF, Func<TIn, TOut> EIJALANKPLO) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class HHNPEBFGDLG<T> : OBKOLGEFKBC<T>, CJHHFDGDDDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string AKJPEFKACOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly IJJNNKCGKIG CKHFMLJDNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool DMJNBPLABAL;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool JNLECKPDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E920", Offset = "0xA9D120", VA = "0x180A9E920", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> HINMCAAKHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract BFIFKPBFBML<T> ABKCGBMDPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4D076A0", Offset = "0x4D05EA0", VA = "0x184D076A0")]
	public HHNPEBFGDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4D072E0", Offset = "0x4D05AE0", VA = "0x184D072E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CLFGCPOKFOO();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class ODIFDDDFOJE<TTask, T> : HHNPEBFGDLG<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class GLLPACHLHED
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
			public GLLPACHLHED <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x423A530", Offset = "0x4238D30", VA = "0x18423A530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x423AAA0", Offset = "0x42392A0", VA = "0x18423AAA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ODIFDDDFOJE<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GLLPACHLHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4CA50C0", Offset = "0x4CA38C0", VA = "0x184CA50C0")]
		[AsyncStateMachine(typeof(ODIFDDDFOJE<, >.GLLPACHLHED.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> BMPNPKGKOAI(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> FEGBHCAEMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource JKCICFOHGAG;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> HINMCAAKHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override BFIFKPBFBML<T> ABKCGBMDPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5728F70", Offset = "0x5727770", VA = "0x185728F70")]
	protected ODIFDDDFOJE(TTask FEGBHCAEMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5728D10", Offset = "0x5727510", VA = "0x185728D10", Slot = "10")]
	protected override void CLFGCPOKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T MAKDFIIPLFD(TTask LLOMGGPJHIF);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void JBPHFNLMCHP();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MBCFNEOKGJM<T> : HHNPEBFGDLG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly KMBNNOIKNHN<Task<T>> JIODCHFCJKK;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> HINMCAAKHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x55256E0", Offset = "0x5523EE0", VA = "0x1855256E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override BFIFKPBFBML<T> ABKCGBMDPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5525760", Offset = "0x5523F60", VA = "0x185525760")]
	public MBCFNEOKGJM(KMBNNOIKNHN<Task<T>> OLHOIDEAJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5525740", Offset = "0x5523F40", VA = "0x185525740", Slot = "10")]
	protected override void CLFGCPOKFOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MAHDGODDGLL
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName KLMEEEPNGEJ;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> AMBGNKJMIHA;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7F65AA0", Offset = "0x7F642A0", VA = "0x187F65AA0")]
	public static int KPLMBBOJNPK(this IPGBBEOGIIF JGOMNHPCAAC, IncrementalHash CEGOJJNEECN, byte[] CFFJGCELIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7F66180", Offset = "0x7F64980", VA = "0x187F66180")]
	public static bool NMIHEBDAINI([CanBeNull] this IPGBBEOGIIF JGOMNHPCAAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7F65B30", Offset = "0x7F64330", VA = "0x187F65B30")]
	public static bool NMIHEBDAINI([CanBeNull] this IPGBBEOGIIF JGOMNHPCAAC, [Out] string MEBFHJECJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7F65E40", Offset = "0x7F64640", VA = "0x187F65E40")]
	public static bool NMIHEBDAINI([CanBeNull] this IPGBBEOGIIF JGOMNHPCAAC, IncrementalHash CEGOJJNEECN, byte[] CFFJGCELIPL, [Out] string MEBFHJECJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7F661E0", Offset = "0x7F649E0", VA = "0x187F661E0")]
	private static bool OBIAAOEIDDM(byte[] FFAAPFOKDJJ, Span<byte> LOLKKMAJFDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MCMDKJNLKLP
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7F663B0", Offset = "0x7F64BB0", VA = "0x187F663B0")]
	public static int EDNDEDNDHPF(HashAlgorithmName HNEJAFGILFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFBD0", Offset = "0x3ABE3D0", VA = "0x183ABFBD0")]
	public static int KPLMBBOJNPK<T>(this T DPGHEIKJPEJ, byte[] LEPIMMICHID, IncrementalHash CEGOJJNEECN, byte[] CHMEILBIOLA) where T : DJFIBNFNLHL
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface DJFIBNFNLHL
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash CEGOJJNEECN);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface IPGBBEOGIIF : DJFIBNFNLHL
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] JBLNPOGNEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] FJBEFEIHMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class OBFKFNLBBPG
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool EPNNCNFJGIP;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> JGJNMCOAPPI;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> NGEJHJIGKFE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding PJLDJOPPADM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> CJBMLKKCBGG;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3B75E90", Offset = "0x3B74690", VA = "0x183B75E90")]
	public static void MIGOPLADHIK<T>(this IncrementalHash AEGDNFBPODA, [CanBeNull] T EIBGHDHLJMO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3B752B0", Offset = "0x3B73AB0", VA = "0x183B752B0")]
	public static void GPJAHGOAMEN<T>(this IncrementalHash AEGDNFBPODA, [CanBeNull] T DPGHEIKJPEJ) where T : DJFIBNFNLHL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3B75340", Offset = "0x3B73B40", VA = "0x183B75340")]
	public static void JLIODGAJADE<T>(this IncrementalHash AEGDNFBPODA, [CanBeNull] IList<T> ONKKBGNCIBM) where T : DJFIBNFNLHL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7F670E0", Offset = "0x7F658E0", VA = "0x187F670E0")]
	private static bool LPDGKOAPOGK([CanBeNull] DJFIBNFNLHL DPGHEIKJPEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7F66CE0", Offset = "0x7F654E0", VA = "0x187F66CE0")]
	public static void LKDOIHCKCIA(this IncrementalHash CEGOJJNEECN, string? NGNCODGENLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7F665E0", Offset = "0x7F64DE0", VA = "0x187F665E0")]
	public static void FKHFEOOCFEG(this IncrementalHash CEGOJJNEECN, long OLJCAOCFDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7F668E0", Offset = "0x7F650E0", VA = "0x187F668E0")]
	public static void GLGKJIPBJAF(this IncrementalHash CEGOJJNEECN, int MHHCACCFDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7F672E0", Offset = "0x7F65AE0", VA = "0x187F672E0")]
	public static void NPGDOIDBJGE(this IncrementalHash CEGOJJNEECN, short LGIBCBGNPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7F671D0", Offset = "0x7F659D0", VA = "0x187F671D0")]
	public static void NJNPGFOCJOG(this IncrementalHash CEGOJJNEECN, byte GLDAFHHEDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7F66AB0", Offset = "0x7F652B0", VA = "0x187F66AB0")]
	public static void HHDAGDHCBNM(this IncrementalHash CEGOJJNEECN, bool MKNHHMAMDCC, bool JACHFKCPHPP = false, bool AFBGMGNJEKF = false, bool POCJKONNDOM = false, bool CCCBBGKBFFK = false, bool PEOCGEDFCHJ = false, bool FJCBBLGKNAK = false, bool BDFMDOAFNIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3B75860", Offset = "0x3B74060", VA = "0x183B75860")]
	public static void MBJELAKALDI<T>(this IncrementalHash CEGOJJNEECN, T IJLILEGPOCK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7F66C20", Offset = "0x7F65420", VA = "0x187F66C20")]
	public static void KHGGGACBHDA(this IncrementalHash CEGOJJNEECN, float CNFHLIIFMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7F66C80", Offset = "0x7F65480", VA = "0x187F66C80")]
	public static void LADOOFIGBCP(this IncrementalHash CEGOJJNEECN, ulong HPFLKKDEOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7F66580", Offset = "0x7F64D80", VA = "0x187F66580")]
	public static void BKJELPPANEG(this IncrementalHash CEGOJJNEECN, uint BPPAFMEKJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7F67170", Offset = "0x7F65970", VA = "0x187F67170")]
	public static void MLOLNAJLMFM(this IncrementalHash CEGOJJNEECN, ushort OKCEJEHFEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7F667B0", Offset = "0x7F64FB0", VA = "0x187F667B0")]
	public static void GBCJJKPIMFE(this IncrementalHash CEGOJJNEECN, Vector3 JOOMDNAGHBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DEFLIFBGDOH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F65520", Offset = "0x7F63D20", VA = "0x187F65520")]
	public DEFLIFBGDOH(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class JLJPCGKJCEP
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void KGOICFKHMIG(ushort PNNIEMHDPAJ, ushort CKJLOGMPFMM, ushort PGAEPJDJDBO, ushort ICNAALOJGIP);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void KAFBGCDGLCI(ushort PICIHDMONCJ, ushort ECLIGHJALMK);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void BDPMAPBLJAG();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort PBBNJNCDCIN = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected JLJPCGKJCEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class LOACIJPHEMD<T> : JLJPCGKJCEP where T : LOACIJPHEMD<T>.DOKJNDIGLBH
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface DOKJNDIGLBH
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		KAFBGCDGLCI EAAHNMDLCJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		KAFBGCDGLCI KJELCPCOKAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		BDPMAPBLJAG PPMLGFOKIPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> JOBFMALAGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BDPMAPBLJAG IEGMCDKCFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private BDPMAPBLJAG KDIMJHCNMCF;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool ODPMBPFGCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA34760", Offset = "0xA32F60", VA = "0x180A34760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort FCBLIGHAIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x111AFE0", Offset = "0x11197E0", VA = "0x18111AFE0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x111ADE0", Offset = "0x11195E0", VA = "0x18111ADE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort BGKIPLGKPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x53391D0", Offset = "0x53379D0", VA = "0x1853391D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5339300", Offset = "0x5337B00", VA = "0x185339300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort CPFMFOEHLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xE57640", Offset = "0xE55E40", VA = "0x180E57640")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xE57750", Offset = "0xE55F50", VA = "0x180E57750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort DADOOMFGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x53391E0", Offset = "0x53379E0", VA = "0x1853391E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x533A230", Offset = "0x5338A30", VA = "0x18533A230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool EEKANCIGCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x111B1A0", Offset = "0x11199A0", VA = "0x18111B1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool EFAILIIBBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xF4A770", Offset = "0xF48F70", VA = "0x180F4A770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KGOICFKHMIG LDJLCPELOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x533A0E0", Offset = "0x53388E0", VA = "0x18533A0E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x533A180", Offset = "0x5338980", VA = "0x18533A180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x533A240", Offset = "0x5338A40", VA = "0x18533A240")]
	private T PKEAGLADDKF(ushort DELDJDDIBJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x53395A0", Offset = "0x5337DA0", VA = "0x1853395A0")]
	private T HLEGCONFHOL(ushort DELDJDDIBJF, ushort KHGHCGNMJBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5339170", Offset = "0x5337970", VA = "0x185339170")]
	protected T AGPLDCGEBON(uint JJNNDKCJOJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x533A310", Offset = "0x5338B10", VA = "0x18533A310")]
	protected LOACIJPHEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x533A0A0", Offset = "0x53388A0", VA = "0x18533A0A0")]
	public void MADGHMNPONG(ushort AFGALADIOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5339F20", Offset = "0x5338720", VA = "0x185339F20")]
	public void MADGHMNPONG(ushort AFGALADIOFP, ushort MCBOJIJNHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5339F80", Offset = "0x5338780", VA = "0x185339F80", Slot = "4")]
	protected virtual void MADGHMNPONG(uint AEEEHBLCCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5339670", Offset = "0x5337E70", VA = "0x185339670")]
	protected void IOKLFJJHEPD(uint AEEEHBLCCHP, uint OEEIEPACEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5339250", Offset = "0x5337A50", VA = "0x185339250")]
	protected void CMIFBDCABEA(ushort DELDJDDIBJF, ushort KHGHCGNMJBA, T OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x53391F0", Offset = "0x53379F0", VA = "0x1853391F0")]
	private void BLFJFONJMGI(uint JJNNDKCJOJF, T OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5339310", Offset = "0x5337B10", VA = "0x185339310")]
	protected void GJNJCBLFIKM(float JGHFILFLDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x533A300", Offset = "0x5338B00", VA = "0x18533A300")]
	protected uint PNDBAODKBMC(ushort DELDJDDIBJF, ushort KHGHCGNMJBA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x533A220", Offset = "0x5338A20", VA = "0x18533A220")]
	protected ushort PADOFNGFOGG(uint JPCPCJICLDI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5339F10", Offset = "0x5338710", VA = "0x185339F10")]
	protected ushort JLHLBHPNECP(uint JPCPCJICLDI)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class BLNFDFGEHCD : LOACIJPHEMD<BLNFDFGEHCD.ADCEBCIKOCK>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class ADCEBCIKOCK : DOKJNDIGLBH
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public KAFBGCDGLCI EAAHNMDLCJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public KAFBGCDGLCI KJELCPCOKAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public BDPMAPBLJAG PPMLGFOKIPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ADCEBCIKOCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F65130", Offset = "0x7F63930", VA = "0x187F65130")]
	public void NAHBCKKEFDI(ushort FFHFCKLBCAK, KAFBGCDGLCI NHACCKNGJGO, KAFBGCDGLCI FHAOIFLFCMD, BDPMAPBLJAG HLJDPKEJGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F65050", Offset = "0x7F63850", VA = "0x187F65050")]
	public void NAHBCKKEFDI(ushort DELDJDDIBJF, ushort KHGHCGNMJBA, KAFBGCDGLCI NHACCKNGJGO, KAFBGCDGLCI FHAOIFLFCMD, BDPMAPBLJAG HLJDPKEJGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F65000", Offset = "0x7F63800", VA = "0x187F65000")]
	public void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F65210", Offset = "0x7F63A10", VA = "0x187F65210")]
	protected BLNFDFGEHCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class DIGFFPMCPNM : BLNFDFGEHCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool NEFGIMNFAEJ;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xC9B990", Offset = "0xC9A190", VA = "0x180C9B990")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD98160", Offset = "0xD96960", VA = "0x180D98160")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F655E0", Offset = "0x7F63DE0", VA = "0x187F655E0")]
	public void IEAMPCKAMFG(ushort FAFANJMOJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F65580", Offset = "0x7F63D80", VA = "0x187F65580")]
	public void IEAMPCKAMFG(ushort FAFANJMOJJL, ushort FLOCFHOGIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F65210", Offset = "0x7F63A10", VA = "0x187F65210")]
	public DIGFFPMCPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class OMJLBFNPEDG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class AHDLJHJFJBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode DKBBJFIDEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode MJNLMOPPION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GEICPMPNIGE PKBMMFHCONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<GEICPMPNIGE> JONICMMHGDP;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AHDLJHJFJBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct GEICPMPNIGE : IComparable<GEICPMPNIGE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int IAOOMFIBPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant BCPGPAIGFKH;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x175B230", Offset = "0x1759A30", VA = "0x18175B230")]
		public GEICPMPNIGE(int IAOOMFIBPGC, TClaimant BCPGPAIGFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4C82E20", Offset = "0x4C81620", VA = "0x184C82E20")]
		public bool LLFALEINGED([In] GEICPMPNIGE KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4C82E10", Offset = "0x4C81610", VA = "0x184C82E10")]
		public bool LBLGJLPFIFB([In] GEICPMPNIGE KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4C82E00", Offset = "0x4C81600", VA = "0x184C82E00", Slot = "4")]
		public int CompareTo(GEICPMPNIGE KEKEFPAJGHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4C82E80", Offset = "0x4C81680", VA = "0x184C82E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum MCHHONAGCEI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GDIPMDKCBEO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public OMJLBFNPEDG<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public GDIPMDKCBEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C81560", Offset = "0x4C7FD60", VA = "0x184C81560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C81740", Offset = "0x4C7FF40", VA = "0x184C81740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4C81640", Offset = "0x4C7FE40", VA = "0x184C81640", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4BF22B0", Offset = "0x4BF0AB0", VA = "0x184BF22B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly DMJNBPOKINC<AHDLJHJFJBJ> OFGCPHIDKKB;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly DMJNBPOKINC<List<GEICPMPNIGE>> ONDGKIPNDDE;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int IEGGDMAKMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> IGNKFFECHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, AHDLJHJFJBJ> NKJPJKEBMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private MCHHONAGCEI MFMCIMMKBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool LKNCKMOIEPH;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AHDMDAEOOFN(TNode CJEDGIAKFCF);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MKAAPIPCMKF(TNode CJEDGIAKFCF, TClaimant KEEMOIBLNMP, TClaimant KJEADPKKIEA);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5751E20", Offset = "0x5750620", VA = "0x185751E20")]
	public OMJLBFNPEDG(MCHHONAGCEI MFMCIMMKBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5750210", Offset = "0x574EA10", VA = "0x185750210")]
	public void CGJKDFLOPPK(TNode CJEDGIAKFCF, TNode OOBPPDKPNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x57503E0", Offset = "0x574EBE0", VA = "0x1857503E0")]
	public void DHJNMPNMGDK(TClaimant BCPGPAIGFKH, TNode CPPEENAKAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5750580", Offset = "0x574ED80", VA = "0x185750580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5750E30", Offset = "0x574F630", VA = "0x185750E30")]
	private void HAFDEAPCPMD(TClaimant BCPGPAIGFKH, TNode GIMLBLHGIJK, TNode CPPEENAKAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5750F00", Offset = "0x574F700", VA = "0x185750F00")]
	private int IBADEHAGIPL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x57518E0", Offset = "0x57500E0", VA = "0x1857518E0")]
	private void POLIBKKDNDI(TClaimant BCPGPAIGFKH, TNode AHEIBHNIIDJ, TNode AJDDCFHNNNO, int AGEEFLLAGHB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x57510E0", Offset = "0x574F8E0", VA = "0x1857510E0")]
	private void KEMEGEOKCKK(GEICPMPNIGE AOMNLOKCMNI, AHDLJHJFJBJ IJCALHAOPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5750B30", Offset = "0x574F330", VA = "0x185750B30")]
	private void GDOFGGHLFFC(TClaimant BCPGPAIGFKH, TNode AHEIBHNIIDJ, TNode AJDDCFHNNNO, int AGEEFLLAGHB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x57511C0", Offset = "0x574F9C0", VA = "0x1857511C0")]
	private void KHDCMCMBOLH(GEICPMPNIGE AOMNLOKCMNI, TNode CJEDGIAKFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5750F70", Offset = "0x574F770", VA = "0x185750F70")]
	private void IFLFDNHIFDP(GEICPMPNIGE AOMNLOKCMNI, AHDLJHJFJBJ IJCALHAOPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x57515B0", Offset = "0x574FDB0", VA = "0x1857515B0")]
	private void MLHDEKKOPHJ(AHDLJHJFJBJ IJCALHAOPEH, bool OMOFFFGJDIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x57507A0", Offset = "0x574EFA0", VA = "0x1857507A0")]
	private void EKJOODNDNGO(AHDLJHJFJBJ IJCALHAOPEH, TNode OOBPPDKPNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x57502E0", Offset = "0x574EAE0", VA = "0x1857502E0")]
	[IteratorStateMachine(typeof(OMJLBFNPEDG<, >.GDIPMDKCBEO))]
	private IEnumerable<TNode> DFOFBLBELOL(TNode AHEIBHNIIDJ, TNode AJDDCFHNNNO, bool FOLONGNEGKA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5751490", Offset = "0x574FC90", VA = "0x185751490")]
	private AHDLJHJFJBJ LNBPCHNCOMI(TNode CJEDGIAKFCF, TNode MJNLMOPPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5751300", Offset = "0x574FB00", VA = "0x185751300")]
	private AHDLJHJFJBJ LGEHPGAADNK(TNode CJEDGIAKFCF, TNode MJNLMOPPION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5751710", Offset = "0x574FF10", VA = "0x185751710")]
	private void PLDDFLLPAAK(AHDLJHJFJBJ IJCALHAOPEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class PJHONLFLALK<T> : IEnumerable<PJHONLFLALK<T>.OLBMNMOIHFJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct OLBMNMOIHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T MGONBEDEDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int PNJCJGEIDHG;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class GNCPNOGINIE : IEnumerator<OLBMNMOIHFJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private PJHONLFLALK<T> LILGCKMMEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int PNJCJGEIDHG;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4762130", Offset = "0x4760930", VA = "0x184762130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public OLBMNMOIHFJ EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4CAA100", Offset = "0x4CA8900", VA = "0x184CAA100", Slot = "4")]
			get
			{
				return default(OLBMNMOIHFJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4CAA010", Offset = "0x4CA8810", VA = "0x184CAA010")]
		public GNCPNOGINIE(PJHONLFLALK<T> LILGCKMMEFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9F90", Offset = "0x4CA8790", VA = "0x184CA9F90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x47C7AF0", Offset = "0x47C62F0", VA = "0x1847C7AF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1196B40", Offset = "0x1195340", VA = "0x181196B40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct EKCINKGAGFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool PJADHJDHAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T MGONBEDEDON;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int JCBJKCAEHHN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> KAEGLFGCJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private EKCINKGAGFE[] EDNKGPONBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int DDPGBEHFHOI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int KCJOGOBKIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4253080", Offset = "0x4251880", VA = "0x184253080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x58B2DD0", Offset = "0x58B15D0", VA = "0x1858B2DD0")]
	public PJHONLFLALK(int BEMGFNOEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x58B2990", Offset = "0x58B1190", VA = "0x1858B2990")]
	public PJHONLFLALK(OLBMNMOIHFJ[] MJLPHCKNNOI, bool HBKBEGLJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x58B2640", Offset = "0x58B0E40", VA = "0x1858B2640")]
	public int DANDFKGNDJI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x58B2400", Offset = "0x58B0C00", VA = "0x1858B2400")]
	private int CIEKFOPCJIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x58B2800", Offset = "0x58B1000", VA = "0x1858B2800", Slot = "6")]
	protected virtual uint LJIIGHICIHJ(uint CEGOJJNEECN, T MGONBEDEDON)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x58B2890", Offset = "0x58B1090", VA = "0x1858B2890")]
	public bool OAPEOOPBALM(T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x58B1AD0", Offset = "0x58B02D0", VA = "0x1858B1AD0")]
	public int BOAOKNPGJEK(T MGONBEDEDON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x58B2760", Offset = "0x58B0F60", VA = "0x1858B2760")]
	public T IGJBJAKHOGI(int PNJCJGEIDHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x58B2160", Offset = "0x58B0960", VA = "0x1858B2160")]
	public bool CGCACJNCGGH(T MGONBEDEDON, bool JNPIBJDKOIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x58B1BE0", Offset = "0x58B03E0", VA = "0x1858B1BE0")]
	public bool CGCACJNCGGH(T MGONBEDEDON, int PNJCJGEIDHG, bool JNPIBJDKOIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x58B1A30", Offset = "0x58B0230", VA = "0x1858B1A30")]
	private int AHLOLMMKDLB(int COEFDMIBPJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x58B28F0", Offset = "0x58B10F0", VA = "0x1858B28F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x58B28F0", Offset = "0x58B10F0", VA = "0x1858B28F0", Slot = "4")]
	private IEnumerator<OLBMNMOIHFJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DMJNBPOKINC<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> KFIOJDEKGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> EDKJBGKFEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int EHCMJBCKGDG;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B3A0", Offset = "0x6D59BA0", VA = "0x186D5B3A0")]
	public static DMJNBPOKINC<T> PGFPKMBIODM(int BEMGFNOEFHN = 0, int EHCMJBCKGDG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B2A0", Offset = "0x6D59AA0", VA = "0x186D5B2A0")]
	public static DMJNBPOKINC<T> NMGHFONJFLO(int BEMGFNOEFHN = 0, int EHCMJBCKGDG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B4A0", Offset = "0x6D59CA0", VA = "0x186D5B4A0")]
	public DMJNBPOKINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B4F0", Offset = "0x6D59CF0", VA = "0x186D5B4F0")]
	public DMJNBPOKINC(int BEMGFNOEFHN, int EHCMJBCKGDG = int.MaxValue, bool GJBEGAKMAEK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AFD0", Offset = "0x6D597D0", VA = "0x186D5AFD0")]
	public T NENGBNEGMOH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B1B0", Offset = "0x6D599B0", VA = "0x186D5B1B0")]
	public void NJIHLBBHOIK(T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AED0", Offset = "0x6D596D0", VA = "0x186D5AED0")]
	private void JMIILICNDBO(T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AC80", Offset = "0x6D59480", VA = "0x186D5AC80")]
	private void GEGBANMHPGJ(T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AAF0", Offset = "0x6D592F0", VA = "0x186D5AAF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5ACD0", Offset = "0x6D594D0", VA = "0x186D5ACD0")]
	private void JJLPCAHAKLF(IEnumerable<T> IFMNLKCJNMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class KLOPGCFKABH<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> FDLLKGDBNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T CFLHHFFKENN;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T NCNAHNGBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x51BDC90", Offset = "0x51BC490", VA = "0x1851BDC90")]
	public bool FPNDDCPMLEC(T MGONBEDEDON, int IAOOMFIBPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4D31D90", Offset = "0x4D30590", VA = "0x184D31D90")]
	public bool PCPMPDBIOOI(int IAOOMFIBPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x51BE180", Offset = "0x51BC980", VA = "0x1851BE180")]
	public T KLKKIJCIPIF(int ELMPNGEMJNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x51BDD40", Offset = "0x51BC540", VA = "0x1851BDD40")]
	private bool JKLFFOBPELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x51BE3A0", Offset = "0x51BCBA0", VA = "0x1851BE3A0")]
	public bool PLBNMDLFKAN(int IAOOMFIBPGC, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x51BE400", Offset = "0x51BCC00", VA = "0x1851BE400")]
	public KLOPGCFKABH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class JMIDGOEOOJA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct AGCMLIBIPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T HDAKFEADKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int EKKGHIIFODE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<AGCMLIBIPMG> GDNAPNPEGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T NBJNGDKKNDN;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4253080", Offset = "0x4251880", VA = "0x184253080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x50D9640", Offset = "0x50D7E40", VA = "0x1850D9640")]
	public bool HKLOAKDICEJ(T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x50D93E0", Offset = "0x50D7BE0", VA = "0x1850D93E0")]
	public void GGGBGBDKNKJ(T MGONBEDEDON, int IAOOMFIBPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x50D9A30", Offset = "0x50D8230", VA = "0x1850D9A30")]
	public bool HKOLMKDGPPH(T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x50D9250", Offset = "0x50D7A50", VA = "0x1850D9250")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x50D9C40", Offset = "0x50D8440", VA = "0x1850D9C40")]
	public T IFNCEBOHHCG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x50D9D80", Offset = "0x50D8580", VA = "0x1850D9D80")]
	protected void MDKOLADIFDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x50DA0A0", Offset = "0x50D88A0", VA = "0x1850DA0A0")]
	public JMIDGOEOOJA()
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
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7F67A70", Offset = "0x7F66270", VA = "0x187F67A70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7F67D40", Offset = "0x7F66540", VA = "0x187F67D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7F67C50", Offset = "0x7F66450", VA = "0x187F67C50")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7F679C0", Offset = "0x7F661C0", VA = "0x187F679C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7F67C90", Offset = "0x7F66490", VA = "0x187F67C90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7F67BA0", Offset = "0x7F663A0", VA = "0x187F67BA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7F67940", Offset = "0x7F66140", VA = "0x187F67940")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AA4B50", Offset = "0x5AA3350", VA = "0x185AA4B50", Slot = "4")]
		public virtual T GFKBLKBOELE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface JBDIOHLGAIL
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache ALKECMFNBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
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
		public struct KOOJJOJCEHI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> NFJJCCDFOPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool KDNOHAOEBFK;

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x18D8EE0", Offset = "0x18D76E0", VA = "0x1818D8EE0")]
			public KOOJJOJCEHI(List<Component> NFJJCCDFOPE, bool KDNOHAOEBFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x51CB570", Offset = "0x51C9D70", VA = "0x1851CB570")]
			public PODGLNDLOJN<T> KFPOPIJHFBP()
			{
				return default(PODGLNDLOJN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x51CB5E0", Offset = "0x51C9DE0", VA = "0x1851CB5E0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x51CB5E0", Offset = "0x51C9DE0", VA = "0x1851CB5E0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct PODGLNDLOJN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> NFJJCCDFOPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool KDNOHAOEBFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int PNJCJGEIDHG;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T EBPBANINJIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x58CB200", Offset = "0x58C9A00", VA = "0x1858CB200", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x58CB190", Offset = "0x58C9990", VA = "0x1858CB190", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x58CB1D0", Offset = "0x58C99D0", VA = "0x1858CB1D0")]
			public PODGLNDLOJN(List<Component> NFJJCCDFOPE, bool KDNOHAOEBFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x58CB0D0", Offset = "0x58C98D0", VA = "0x1858CB0D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x58CB0E0", Offset = "0x58C98E0", VA = "0x1858CB0E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x47B4230", Offset = "0x47B2A30", VA = "0x1847B4230", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7F69760", Offset = "0x7F67F60", VA = "0x187F69760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7F694C0", Offset = "0x7F67CC0", VA = "0x187F694C0")]
		private void IEAMPCKAMFG(GameObject LEHCGNOJDEA, bool IBCIAMDAPFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7F69630", Offset = "0x7F67E30", VA = "0x187F69630")]
		public static void IEAMPCKAMFG(GameObject LEHCGNOJDEA, ToolHierarchyCache LPHLJKPCIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7F696C0", Offset = "0x7F67EC0", VA = "0x187F696C0")]
		public void IHJKCKCNDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0AF0", Offset = "0x3DAF2F0", VA = "0x183DB0AF0")]
		public void BONGHEJFFJD<T>(Action<T> AMNCPNDDCLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0DF0", Offset = "0x3DAF5F0", VA = "0x183DB0DF0")]
		public T LDJHOKIDIEL<T>(bool KDNOHAOEBFK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0D30", Offset = "0x3DAF530", VA = "0x183DB0D30")]
		public KOOJJOJCEHI<T> EEBEFNPDPEH<T>(bool KDNOHAOEBFK = false) where T : class
		{
			return default(KOOJJOJCEHI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7F69050", Offset = "0x7F67850", VA = "0x187F69050")]
		public List<Component> CPAOENAFNAD(Type CEPGAJKBPDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7F693D0", Offset = "0x7F67BD0", VA = "0x187F693D0", Slot = "4")]
		public bool Equals(ToolHierarchyCache BDGPJOKJNIL, ToolHierarchyCache HDAFCDJNHAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7F69450", Offset = "0x7F67C50", VA = "0x187F69450", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HPLLAPMNIJF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class OPNKBNHEHOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int BEMGFNOEFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int PHFFKFMNBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> IDAPMLPCJOA;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x55256E0", Offset = "0x5523EE0", VA = "0x1855256E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T ALDBJLLBKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x576A490", Offset = "0x5768C90", VA = "0x18576A490")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T PIDJAIMJLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5769E20", Offset = "0x5768620", VA = "0x185769E20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T GFPILBLCBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5769D10", Offset = "0x5768510", VA = "0x185769D10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x576A600", Offset = "0x5768E00", VA = "0x18576A600")]
	public OPNKBNHEHOO(int BEMGFNOEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5769F30", Offset = "0x5768730", VA = "0x185769F30")]
	public void GGGBGBDKNKJ(T CIOHBIGFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5769CB0", Offset = "0x57684B0", VA = "0x185769CB0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x576A2C0", Offset = "0x5768AC0", VA = "0x18576A2C0")]
	public void HIBEKHIOABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x576A590", Offset = "0x5768D90", VA = "0x18576A590")]
	public void ONBKABLKNJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5769CA0", Offset = "0x57684A0", VA = "0x185769CA0")]
	public void BCKBLKAMMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x576A220", Offset = "0x5768A20", VA = "0x18576A220")]
	public List<T> GIDCDMPMCIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class IJCFLIBNNJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct LJIMDFKLIOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int EKKGHIIFODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T HDAKFEADKFH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, LJIMDFKLIOG> FDLLKGDBNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> GJILBNECAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T CFLHHFFKENN;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T NCNAHNGBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xDC2E90", Offset = "0xDC1690", VA = "0x180DC2E90", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x4E822C0", Offset = "0x4E80AC0", VA = "0x184E822C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool OONNHIMBNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x4E7E5D0", Offset = "0x4E7CDD0", VA = "0x184E7E5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object CFEBPKGGFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E630", Offset = "0x4E7CE30", VA = "0x184E7E630")]
	public bool FPNDDCPMLEC(T MGONBEDEDON, object KAJENDFCCBJ, int IAOOMFIBPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4E82360", Offset = "0x4E80B60", VA = "0x184E82360")]
	public bool PCPMPDBIOOI(object KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4E82820", Offset = "0x4E81020", VA = "0x184E82820")]
	public bool PLBNMDLFKAN(object KAJENDFCCBJ, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E570", Offset = "0x4E7CD70", VA = "0x184E7E570")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4E80B70", Offset = "0x4E7F370", VA = "0x184E80B70")]
	private bool JKLFFOBPELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4E82D30", Offset = "0x4E81530", VA = "0x184E82D30")]
	public IJCFLIBNNJN()
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
