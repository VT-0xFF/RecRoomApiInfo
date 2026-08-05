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
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using RecRoom.DataStructures.Hashing;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Caching;
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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x997B1C0", Offset = "0x9979BC0", VA = "0x18997B1C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CompactArrayDrawerAttribute : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x229DA80", Offset = "0x229C480", VA = "0x18229DA80")]
	public CompactArrayDrawerAttribute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, OWLJRTYPLBR, PCYXCBYNPOB, ISerializationCallbackReceiver
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
	public byte[] QFAZUUNMXJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] EZSZCWBIOUX
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object GEOXHZHDAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash hash);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xDAA5B0", Offset = "0xDA8FB0", VA = "0x180DAA5B0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float MZEANYCVLJX;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float VWEDCMAICDS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x997E110", Offset = "0x997CB10", VA = "0x18997E110")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x997E0D0", Offset = "0x997CAD0", VA = "0x18997E0D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x997E150", Offset = "0x997CB50", VA = "0x18997E150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x997E270", Offset = "0x997CC70", VA = "0x18997E270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x997E1D0", Offset = "0x997CBD0", VA = "0x18997E1D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD68AE0", Offset = "0xD674E0", VA = "0x180D68AE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD67C20", Offset = "0xD66620", VA = "0x180D67C20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x997E0B0", Offset = "0x997CAB0", VA = "0x18997E0B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xEE2370", Offset = "0xEE0D70", VA = "0x180EE2370")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x997DA90", Offset = "0x997C490", VA = "0x18997DA90")]
	public void CopyBounds(SavedExtents other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x997E010", Offset = "0x997CA10", VA = "0x18997E010")]
	public void SetLocalSpaceBounds(Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1741110", Offset = "0x173FB10", VA = "0x181741110")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x997DE00", Offset = "0x997C800", VA = "0x18997DE00")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x997DE10", Offset = "0x997C810", VA = "0x18997DE10")]
	private void RTJRTVSWGMS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x997DB80", Offset = "0x997C580", VA = "0x18997DB80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x997D440", Offset = "0x997BE40", VA = "0x18997D440")]
	public static void CalculateLocalBoundsFor(GameObject gameObject, [Out] Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x997DAC0", Offset = "0x997C4C0", VA = "0x18997DAC0")]
	private static void OHCPRDJFYHL(Bounds a, Color b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x997E030", Offset = "0x997CA30", VA = "0x18997E030")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C78880", Offset = "0x1C77280", VA = "0x181C78880")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7925F00", Offset = "0x7924900", VA = "0x187925F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
	public virtual void CMHMSXWEGWS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
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
	[CompactArrayDrawer]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7923910", Offset = "0x7922310", VA = "0x187923910", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7922710", Offset = "0x7921110", VA = "0x187922710", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7923C90", Offset = "0x7922690", VA = "0x187923C90")]
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
	private sealed class EDTROWESFHS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> GTCJDRVTNXT;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public EDTROWESFHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B3FE30", Offset = "0x5B3E830", VA = "0x185B3FE30")]
		internal int UAASCKSNEUM(TKeyVal a, TKeyVal b)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[CompactArrayDrawer]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> VSOTKSEOWJK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5BB26D0", Offset = "0x5BB10D0", VA = "0x185BB26D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2750", Offset = "0x5BB1150", VA = "0x185BB2750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2450", Offset = "0x5BB0E50", VA = "0x185BB2450", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey key]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BB2500", Offset = "0x5BB0F00", VA = "0x185BB2500", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> ZASVYFFWXYD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BB1FB0", Offset = "0x5BB09B0", VA = "0x185BB1FB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5BB1B90", Offset = "0x5BB0590", VA = "0x185BB1B90", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0EE0", Offset = "0x5BAF8E0", VA = "0x185BB0EE0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0EB0", Offset = "0x5BAF8B0", VA = "0x185BB0EB0", Slot = "14")]
	protected virtual string MFANFCJVAUP(TKeyVal a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0C00", Offset = "0x5BAF600", VA = "0x185BB0C00", Slot = "4")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5BB1D20", Offset = "0x5BB0720", VA = "0x185BB1D20", Slot = "5")]
	public bool TryGetValue(TKey key, [Out] TVal value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0CE0", Offset = "0x5BAF6E0", VA = "0x185BB0CE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0CE0", Offset = "0x5BAF6E0", VA = "0x185BB0CE0", Slot = "11")]
	private IEnumerator XDTPACFLBGX()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5BB2370", Offset = "0x5BB0D70", VA = "0x185BB2370")]
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
		[Cpp2IlInjected.Address(RVA = "0xF35A80", Offset = "0xF34480", VA = "0x180F35A80")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF35AA0", Offset = "0xF344A0", VA = "0x180F35AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[CompactArrayDrawer]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7928270", Offset = "0x7926C70", VA = "0x187928270")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7927ED0", Offset = "0x79268D0", VA = "0x187927ED0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7927540", Offset = "0x7925F40", VA = "0x187927540", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class JMMUXZWRTQZ<a>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BufferEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public a Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float Timestamp;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int IKELNWBGNNO = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float TFIBTFTBIPB = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly BufferEntry[] GQRFWSMTFZB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int JIKZGUNDQQA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float VMIHZDEQAXO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDBD950", Offset = "0xDBC350", VA = "0x180DBD950")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDF5750", Offset = "0xDF4150", VA = "0x180DF5750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public a SABVOKOGAUS
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1A4AEC0", Offset = "0x1A498C0", VA = "0x181A4AEC0")]
		[CompilerGenerated]
		get
		{
			return (a)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7EF0", Offset = "0x66D68F0", VA = "0x1866D7EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x66D80B0", Offset = "0x66D6AB0", VA = "0x1866D80B0")]
	protected JMMUXZWRTQZ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x66D7F00", Offset = "0x66D6900", VA = "0x1866D7F00")]
	protected JMMUXZWRTQZ(int a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x66D7BE0", Offset = "0x66D65E0", VA = "0x1866D7BE0")]
	public void Add(float time, a value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool CRUYHTECDQC(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool BXXEIVVNHGB(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x66D7DF0", Offset = "0x66D67F0", VA = "0x1866D7DF0")]
	public void Clear()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class TQDKIWTGRIS : JMMUXZWRTQZ<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x997E870", Offset = "0x997D270", VA = "0x18997E870", Slot = "4")]
	public override bool CRUYHTECDQC(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x997E730", Offset = "0x997D130", VA = "0x18997E730", Slot = "5")]
	public override bool BXXEIVVNHGB(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x997E9D0", Offset = "0x997D3D0", VA = "0x18997E9D0")]
	public TQDKIWTGRIS()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3F964B0", Offset = "0x3F94EB0", VA = "0x183F964B0")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F965B0", Offset = "0x3F94FB0", VA = "0x183F965B0")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F98490", Offset = "0x6F96E90", VA = "0x186F98490")]
	internal static int ODHWWHRUOVJ(int a, int b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8B29E80", Offset = "0x8B28880", VA = "0x188B29E80")]
	internal static int ODHWWHRUOVJ(int a, int b, int c)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class Tuple<T1, T2> : IComparable<Tuple<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 QVCIBYKHDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 QVSCTSRZFQB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0B90", Offset = "0x7C9F590", VA = "0x187CA0B90")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F000", Offset = "0x7C9DA00", VA = "0x187C9F000", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9FA90", Offset = "0x7C9E490", VA = "0x187C9FA90", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9FF70", Offset = "0x7C9E970", VA = "0x187C9FF70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA06D0", Offset = "0x7C9F0D0", VA = "0x187CA06D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Tuple<T1, T2, T3> : IComparable<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 QVCIBYKHDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 QVSCTSRZFQB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 QVMVWLYBWES;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC480", Offset = "0x7CAAE80", VA = "0x187CAC480")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8200", Offset = "0x7CA6C00", VA = "0x187CA8200", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA89B0", Offset = "0x7CA73B0", VA = "0x187CA89B0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CA92D0", Offset = "0x7CA7CD0", VA = "0x187CA92D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC300", Offset = "0x7CAAD00", VA = "0x187CAC300", Slot = "3")]
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
	public AnimationCurve TBXNXJNGTFT
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T GRYOTGAFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x105C3D0", Offset = "0x105ADD0", VA = "0x18105C3D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T NOGTOTSJMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xDAA5C0", Offset = "0xDA8FC0", VA = "0x180DAA5C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T BPERYPXGUEX
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3012850", Offset = "0x3011250", VA = "0x183012850")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x30126F0", Offset = "0x30110F0", VA = "0x1830126F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float EYNIIESDTNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xDA9400", Offset = "0xDA7E00", VA = "0x180DA9400")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80606E0", Offset = "0x805F0E0", VA = "0x1880606E0")]
	public T SMBBYXZKBHT(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80603C0", Offset = "0x805EDC0", VA = "0x1880603C0")]
	public T KIFDKKQABZD(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DLBNHPNNTGN(T a, T b, float c);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x997AE30", Offset = "0x9979830", VA = "0x18997AE30", Slot = "4")]
	protected override float DLBNHPNNTGN(float a, float b, float c)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x997AE70", Offset = "0x9979870", VA = "0x18997AE70")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A99810", Offset = "0x1A98210", VA = "0x181A99810", Slot = "4")]
	protected override Vector3 DLBNHPNNTGN(Vector3 a, Vector3 b, float c)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x997F580", Offset = "0x997DF80", VA = "0x18997F580")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x997ACD0", Offset = "0x99796D0", VA = "0x18997ACD0", Slot = "4")]
	protected override Color DLBNHPNNTGN(Color a, Color b, float c)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x997AD90", Offset = "0x9979790", VA = "0x18997AD90")]
	public ColorValueCurve()
	{
	}
}
namespace Structures.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ACGTDYYKFZO : TZQRYKARDKQ<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x997ABF0", Offset = "0x99795F0", VA = "0x18997ABF0")]
		public ACGTDYYKFZO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x997AB80", Offset = "0x9979580", VA = "0x18997AB80", Slot = "6")]
		protected override uint TKGSROURAKG(uint a, string b)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class PMNHIMQCEZK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly IDisposable UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public PMNHIMQCEZK()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct AwaitableRpc<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> _roundTripRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int _lastActorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int _requestId;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4EF9B80", Offset = "0x4EF8580", VA = "0x184EF9B80")]
		private AwaitableRpc(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> roundTripRequests, int lastActorId, int requestId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4EF99D0", Offset = "0x4EF83D0", VA = "0x184EF99D0")]
		public static AwaitableRpc<T> New()
		{
			return default(AwaitableRpc<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4EF88F0", Offset = "0x4EF72F0", VA = "0x184EF88F0")]
		public (int, int, Task<T>) IFEHAIHSILV(int a, [Optional] CancellationToken b, double c = 60.0)
		{
			return default((int, int, Task<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF9480", Offset = "0x4EF7E80", VA = "0x184EF9480")]
		public void JBMHNUDPVAC(int a, int b, [In] T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class SOWLDPJOVPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x997D3F0", Offset = "0x997BDF0", VA = "0x18997D3F0")]
		public static AwaitableRpc<None> New()
		{
			return default(AwaitableRpc<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x997D370", Offset = "0x997BD70", VA = "0x18997D370")]
		public static void JBMHNUDPVAC([In] this AwaitableRpc<None> self, int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class VXHTUMSVKHZ<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Dictionary<a, b> BVNWAREUMUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Dictionary<b, a> AOQPUTUFVYZ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D3A0", Offset = "0x7A6BDA0", VA = "0x187A6D3A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7FBF9B0", Offset = "0x7FBE3B0", VA = "0x187FBF9B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7FBFA20", Offset = "0x7FBE420", VA = "0x187FBFA20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7FBF6F0", Offset = "0x7FBE0F0", VA = "0x187FBF6F0", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7FBFBC0", Offset = "0x7FBE5C0", VA = "0x187FBFBC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public a this[b key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7FBF940", Offset = "0x7FBE340", VA = "0x187FBF940")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD910", Offset = "0x7FBC310", VA = "0x187FBD910", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF210", Offset = "0x7FBDC10", VA = "0x187FBF210", Slot = "20")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD310", Offset = "0x7FBBD10", VA = "0x187FBD310", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD620", Offset = "0x7FBC020", VA = "0x187FBD620", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDAD0", Offset = "0x7FBC4D0", VA = "0x187FBDAD0", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDBA0", Offset = "0x7FBC5A0", VA = "0x187FBDBA0", Slot = "16")]
		public bool Contains(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE6C0", Offset = "0x7FBD0C0", VA = "0x187FBE6C0", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE6C0", Offset = "0x7FBD0C0", VA = "0x187FBE6C0", Slot = "18")]
		public bool Remove(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7FBED60", Offset = "0x7FBD760", VA = "0x187FBED60", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDE20", Offset = "0x7FBC820", VA = "0x187FBDE20", Slot = "19")]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDDC0", Offset = "0x7FBC7C0", VA = "0x187FBDDC0", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE570", Offset = "0x7FBCF70", VA = "0x187FBE570")]
		public bool MAVXVFMPMHQ(b a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE800", Offset = "0x7FBD200", VA = "0x187FBE800")]
		private void TGBDXNCSZCA(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE0A0", Offset = "0x7FBCAA0", VA = "0x187FBE0A0")]
		private void IMGAZXIFZXJ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7FBEE80", Offset = "0x7FBD880", VA = "0x187FBEE80")]
		private bool WHGYMTYABAT(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF4C0", Offset = "0x7FBDEC0", VA = "0x187FBF4C0")]
		public VXHTUMSVKHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class YPJYRHTMXEK<a> : IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private YPJYRHTMXEK<a> buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private a current;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public a Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x15AD920", Offset = "0x15AC320", VA = "0x1815AD920", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x5BEC1C0", Offset = "0x5BEABC0", VA = "0x185BEC1C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5BED5A0", Offset = "0x5BEBFA0", VA = "0x185BED5A0")]
			public Enumerator(YPJYRHTMXEK<a> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC0A0", Offset = "0x5BEAAA0", VA = "0x185BEC0A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x5BEB580", Offset = "0x5BE9F80", VA = "0x185BEB580", Slot = "8")]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC2E0", Offset = "0x5BEACE0", VA = "0x185BEC2E0")]
			private void RIVIAENVABQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private a[] IPPCTJYFWCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int NTDLSDJMVYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int CCYXVNQXPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int version;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x514D940", Offset = "0x514C340", VA = "0x18514D940", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x514D980", Offset = "0x514C380", VA = "0x18514D980")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x514DAC0", Offset = "0x514C4C0", VA = "0x18514DAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x514D8C0", Offset = "0x514C2C0", VA = "0x18514D8C0")]
		public YPJYRHTMXEK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x514D330", Offset = "0x514BD30", VA = "0x18514D330")]
		public void Add(a t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x514CE00", Offset = "0x514B800", VA = "0x18514CE00")]
		public void AFBDVCGAZZM(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x514D400", Offset = "0x514BE00", VA = "0x18514D400")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x514D760", Offset = "0x514C160", VA = "0x18514D760")]
		public void SCXQXNCWLUV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x514D420", Offset = "0x514BE20", VA = "0x18514D420")]
		public void CopyTo(a[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x514D6A0", Offset = "0x514C0A0", VA = "0x18514D6A0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x514D580", Offset = "0x514BF80", VA = "0x18514D580", Slot = "4")]
		private IEnumerator<a> EZYGKGYZAUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x514D580", Offset = "0x514BF80", VA = "0x18514D580", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x514D7E0", Offset = "0x514C1E0", VA = "0x18514D7E0")]
		private int VXXCJHJTHAX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x514D730", Offset = "0x514C130", VA = "0x18514D730")]
		private int OQRJZDBTUHF(int a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class GEDOQJUTDRB<a, b> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public delegate Task<b> RequestProcessor(a request, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public enum ProcessMethod
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			FirstInFirstOut,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			LastInFirstOut
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public class LJRRIDDRKCA
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private const float XEWOLTBTURI = 60f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TimeSpan BRWXJRHULLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int DEZMTCKDWIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ProcessMethod CWLTAIDCDIW;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly LJRRIDDRKCA FYBGHSPAYRJ;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public float YZQENUJOVJX
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x68C77B0", Offset = "0x68C61B0", VA = "0x1868C77B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public TimeSpan NPDPSWAUFVI
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				get
				{
					return default(TimeSpan);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x68C7B80", Offset = "0x68C6580", VA = "0x1868C7B80")]
			public LJRRIDDRKCA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private readonly struct QueueItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public readonly a request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public readonly CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public readonly TaskCompletionSource<b> taskCompletionSource;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x761F800", Offset = "0x761E200", VA = "0x18761F800")]
			public QueueItem(a request, TaskCompletionSource<b> taskCompletionSource, CancellationToken cancellationToken)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <DequeueItemAndRun>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public GEDOQJUTDRB<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private QueueItem <req>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6667BC0", Offset = "0x66665C0", VA = "0x186667BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x66689A0", Offset = "0x66673A0", VA = "0x1866689A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct <StartQueueProcess>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public GEDOQJUTDRB<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6DB27C0", Offset = "0x6DB11C0", VA = "0x186DB27C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6DB2BC0", Offset = "0x6DB15C0", VA = "0x186DB2BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CancellationTokenSource LUQEBARJINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly List<QueueItem> QWXMHHLIJUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly LJRRIDDRKCA EBYCBMYHMSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly RequestProcessor EVFXTNKJIEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Task FBWLDCNVGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int QODMDSQKTHB;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x645B040", Offset = "0x6459A40", VA = "0x18645B040")]
		public GEDOQJUTDRB(RequestProcessor a, [Optional] LJRRIDDRKCA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x645ABC0", Offset = "0x64595C0", VA = "0x18645ABC0")]
		public Task<b> YAVLAQBZKQK(a a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6459870", Offset = "0x6458270", VA = "0x186459870")]
		private void KGMWRCAGUID(QueueItem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64596B0", Offset = "0x64580B0", VA = "0x1864596B0")]
		[AsyncStateMachine(typeof(GEDOQJUTDRB<, >.<StartQueueProcess>d__12))]
		private Task FNTZTNYSKSK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64590D0", Offset = "0x6457AD0", VA = "0x1864590D0")]
		private QueueItem DABAARYCTAQ()
		{
			return default(QueueItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x645A320", Offset = "0x6458D20", VA = "0x18645A320")]
		[AsyncStateMachine(typeof(GEDOQJUTDRB<, >.<DequeueItemAndRun>d__14))]
		private Task XYCQCXLJJND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6459D00", Offset = "0x6458700", VA = "0x186459D00")]
		private void OQKQFBPQAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6459590", Offset = "0x6457F90", VA = "0x186459590", Slot = "4")]
		public void Dispose()
		{
		}
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
namespace RecRoom.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RHCHATXWJCJ<a> : IList<a>, ICollection<a>, IEnumerable<a>, IEnumerable, IReadOnlyList<a>, IReadOnlyCollection<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly List<a> EXTXSTEJPQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HashSet<a> GAKRQVMDOAS;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x286EF10", Offset = "0x286D910", VA = "0x18286EF10", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x76469F0", Offset = "0x76453F0", VA = "0x1876469F0", Slot = "18")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7646D20", Offset = "0x7645720", VA = "0x187646D20", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7645720", Offset = "0x7644120", VA = "0x187645720", Slot = "11")]
		public void Add(a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7646490", Offset = "0x7644E90", VA = "0x187646490")]
		public bool UOHDBVFAYZI(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7646410", Offset = "0x7644E10", VA = "0x187646410", Slot = "15")]
		public bool Remove(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7645A40", Offset = "0x7644440", VA = "0x187645A40", Slot = "16")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x76467B0", Offset = "0x76451B0", VA = "0x1876467B0", Slot = "17")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7645800", Offset = "0x7644200", VA = "0x187645800", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x76458C0", Offset = "0x76442C0", VA = "0x1876458C0", Slot = "13")]
		public bool Contains(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7645A10", Offset = "0x7644410", VA = "0x187645A10", Slot = "14")]
		public void CopyTo(a[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7645B60", Offset = "0x7644560", VA = "0x187645B60", Slot = "6")]
		public int IndexOf(a item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7645F00", Offset = "0x7644900", VA = "0x187645F00", Slot = "7")]
		public void Insert(int index, a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7645FD0", Offset = "0x76449D0", VA = "0x187645FD0", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7646830", Offset = "0x7645230", VA = "0x187646830")]
		public RHCHATXWJCJ()
		{
		}
	}
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
		private Guid LPZNHOENIDK;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2E40B60", Offset = "0x2E3F560", VA = "0x182E40B60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x73BDE80", Offset = "0x73BC880", VA = "0x1873BDE80")]
		public SerializedGuid([In] Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x997E4F0", Offset = "0x997CEF0", VA = "0x18997E4F0")]
		public static SerializedGuid KVKHHAZVRZT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x997E610", Offset = "0x997D010", VA = "0x18997E610")]
		public static SerializedGuid XXBTTUBYITX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x997E490", Offset = "0x997CE90", VA = "0x18997E490")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x997E5E0", Offset = "0x997CFE0", VA = "0x18997E5E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x997E560", Offset = "0x997CF60", VA = "0x18997E560", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x997E3B0", Offset = "0x997CDB0", VA = "0x18997E3B0", Slot = "7")]
		public bool Equals(SerializedGuid other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x997E3F0", Offset = "0x997CDF0", VA = "0x18997E3F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x997E480", Offset = "0x997CE80", VA = "0x18997E480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x997E380", Offset = "0x997CD80", VA = "0x18997E380", Slot = "6")]
		public int CompareTo(SerializedGuid other)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedGuidSourceAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly Type ValueRetrieveMethodType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly string ValueRetrieveMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly bool InsertEmptyChoice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly bool Disabled;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x997E310", Offset = "0x997CD10", VA = "0x18997E310")]
		public SerializedGuidSourceAttribute(Type valueRetrieveMethodType, string valueRetrieveMethod, bool insertEmptyChoice = false, bool disabled = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface EYYDNGMGGZD<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		int VEKHSCHXXUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<a> KWOXGOFWLOB(float a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ENTFDJNXXZV(float a, a b);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class HPIFJODKEQU<a> : EYYDNGMGGZD<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct Sample
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly a Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly float Time;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1076200", Offset = "0x1074C00", VA = "0x181076200")]
			public Sample(a value, float time)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JXYIHMZXBYP : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private a RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public HPIFJODKEQU<a> TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private float ERYPPMJGICT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float GMCRSGTDETY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float? QMPHPZNIBXR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float? OIWDMNFLVOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int LMFPAKYBRIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int XBVIABZLQWX;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private a KCZFSMOPHDD
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xEDB2E0", Offset = "0xED9CE0", VA = "0x180EDB2E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x6576130", Offset = "0x6574B30", VA = "0x186576130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x15E64E0", Offset = "0x15E4EE0", VA = "0x1815E64E0")]
			[DebuggerHidden]
			public JXYIHMZXBYP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x66E2BB0", Offset = "0x66E15B0", VA = "0x1866E2BB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x66E2550", Offset = "0x66E0F50", VA = "0x1866E2550", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> EZYGKGYZAUK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x66E2CE0", Offset = "0x66E16E0", VA = "0x1866E2CE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly float XUKVFPLJRZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly float DPLWGRRGNFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly List<Sample> XVNPMPISCYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int NTDLSDJMVYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int SWEVUYXSKRN;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int VEKHSCHXXUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x652ADE0", Offset = "0x65297E0", VA = "0x18652ADE0")]
		public HPIFJODKEQU(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x652A020", Offset = "0x6528A20", VA = "0x18652A020", Slot = "6")]
		public bool ENTFDJNXXZV(float a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x652ABA0", Offset = "0x65295A0", VA = "0x18652ABA0", Slot = "8")]
		public int XAVQJSXVKBX(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x652A790", Offset = "0x6529190", VA = "0x18652A790", Slot = "5")]
		[IteratorStateMachine(typeof(HPIFJODKEQU<>.JXYIHMZXBYP))]
		public IEnumerable<a> KWOXGOFWLOB(float a, float? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6529FB0", Offset = "0x65289B0", VA = "0x186529FB0", Slot = "7")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x652AB10", Offset = "0x6529510", VA = "0x18652AB10")]
		private void RAXXZLPYTXW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x652A840", Offset = "0x6529240", VA = "0x18652A840")]
		private Sample POPMFBXEIJS()
		{
			return default(Sample);
		}
	}
}
namespace RecRoom.DataStructures.Times
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class StackTimer<TKey> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public readonly struct TimerEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public readonly long startTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly long endTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly int startFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public readonly int endFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public readonly bool isDone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private readonly string stackTrace;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7BBFA60", Offset = "0x7BBE460", VA = "0x187BBFA60")]
			public TimerEntry(long startTicks, int startFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7BBFA30", Offset = "0x7BBE430", VA = "0x187BBFA30")]
			public TimerEntry(long startTicks, long endTicks, int startFrame, int endFrame, bool isDone, string stackTrace)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF730", Offset = "0x7BBE130", VA = "0x187BBF730")]
			public int BBTSBJJDYQK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF8A0", Offset = "0x7BBE2A0", VA = "0x187BBF8A0")]
			public int RMWCUMKDGXU(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF920", Offset = "0x7BBE320", VA = "0x187BBF920")]
			public double WEAQAMNIBIQ()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF800", Offset = "0x7BBE200", VA = "0x187BBF800")]
			public TimerEntry EJHTALTWMIZ(long a, int b)
			{
				return default(TimerEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class SIDKUMXSKTX : IDisposable
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000033")]
			[CompilerGenerated]
			private struct <WrapAsync>d__17<T> : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400007F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000080")]
				public AsyncTaskMethodBuilder<T> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000081")]
				public SIDKUMXSKTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public TKey key;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				public Func<SIDKUMXSKTX, Task<T>> function;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				private SIDKUMXSKTX <internalTimer>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				private TaskAwaiter<T> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x719EC90", Offset = "0x719D690", VA = "0x18719EC90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x66799E0", Offset = "0x66783E0", VA = "0x1866799E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public readonly TKey PMSYNPVRYWB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private readonly StackTimer<TKey> WQPRTSQVXSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public readonly Log WVPIFBCBMJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private List<SIDKUMXSKTX> IFSVKUKCEOV;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public string HKCTBXAMAKD
			{
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x78F16F0", Offset = "0x78F00F0", VA = "0x1878F16F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public IEnumerable<SIDKUMXSKTX> IXEJHKRESMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x78F2260", Offset = "0x78F0C60", VA = "0x1878F2260")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public TimerEntry GARVEZVMZIV
			{
				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x219CE00", Offset = "0x219B800", VA = "0x18219CE00")]
				[CompilerGenerated]
				get
				{
					return default(TimerEntry);
				}
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x78F22F0", Offset = "0x78F0CF0", VA = "0x1878F22F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x78F26D0", Offset = "0x78F10D0", VA = "0x1878F26D0")]
			internal SIDKUMXSKTX(StackTimer<TKey> a, TKey b, Log c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x78F1720", Offset = "0x78F0120", VA = "0x1878F1720")]
			public SIDKUMXSKTX DXYIHFOGWTR(TKey a, [Optional] Log? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x3F110E0", Offset = "0x3F0FAE0", VA = "0x183F110E0")]
			[AsyncStateMachine(typeof(<WrapAsync>d__17<>))]
			public Task<b> RVKCFXNKPEK<b>(TKey a, Func<SIDKUMXSKTX, Task<b>> b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x78F2070", Offset = "0x78F0A70", VA = "0x1878F2070", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class CYAVNYCNEPH : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public StackTimer<TKey> TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> IRFNBWFCZWO;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private (TKey, List<TKey>, TimerEntry) UEOTSGPNYBS
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x2E3C6B0", Offset = "0x2E3B0B0", VA = "0x182E3C6B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x50B3A10", Offset = "0x50B2410", VA = "0x1850B3A10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2E3C910", Offset = "0x2E3B310", VA = "0x182E3C910")]
			[DebuggerHidden]
			public CYAVNYCNEPH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x50B2F40", Offset = "0x50B1940", VA = "0x1850B2F40", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x50B30A0", Offset = "0x50B1AA0", VA = "0x1850B30A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x50B3B50", Offset = "0x50B2550", VA = "0x1850B3B50")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x50B2E90", Offset = "0x50B1890", VA = "0x1850B2E90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> GFRKDDBNDPJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x50B3A60", Offset = "0x50B2460", VA = "0x1850B3A60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class CXVOQRIPVDY : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private List<TKey> JTJMCGSGBGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public List<TKey> TKVABEDCEPS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private SIDKUMXSKTX RXRAGOITECR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public SIDKUMXSKTX KYASSAMBGDS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public StackTimer<TKey> TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private IEnumerator<SIDKUMXSKTX> IRFNBWFCZWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> IRAGEPLFQLF;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			private (TKey, List<TKey>, TimerEntry) UEOTSGPNYBS
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2E3C6B0", Offset = "0x2E3B0B0", VA = "0x182E3C6B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0x50B27A0", Offset = "0x50B11A0", VA = "0x1850B27A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2E3C910", Offset = "0x2E3B310", VA = "0x182E3C910")]
			[DebuggerHidden]
			public CXVOQRIPVDY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x50B0F40", Offset = "0x50AF940", VA = "0x1850B0F40", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x50B20C0", Offset = "0x50B0AC0", VA = "0x1850B20C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x50B2AA0", Offset = "0x50B14A0", VA = "0x1850B2AA0")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x50B2BF0", Offset = "0x50B15F0", VA = "0x1850B2BF0")]
			private void XNORPFATVNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x50B0BF0", Offset = "0x50AF5F0", VA = "0x1850B0BF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> GFRKDDBNDPJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x50B28D0", Offset = "0x50B12D0", VA = "0x1850B28D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Action<TKey, TimerEntry, Log> ILNTULOORBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Action<TKey, TimerEntry, Log> GIZKSDWBZQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Action<StackTimer<TKey>, Log> TVSVYBCFWGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly SIDKUMXSKTX ARVICDNIQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool WQKINWPMPUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int LRUPEEBPQQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Stopwatch ZJYACGJELHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly int HCCDRAIXYMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private string JGARICLPRTE;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public SIDKUMXSKTX MYCQUSFOMIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		[NotNull]
		public string HKCTBXAMAKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7A154E0", Offset = "0x7A13EE0", VA = "0x187A154E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A15DF0", Offset = "0x7A147F0", VA = "0x187A15DF0")]
		public StackTimer(TKey rootKey, Log log, [Optional] int? startFrame, [Optional][CanBeNull] Stopwatch stopwatch, [Optional] Action<TKey, TimerEntry, Log> pushCallback, [Optional] Action<TKey, TimerEntry, Log> popCallback, [Optional] Action<StackTimer<TKey>, Log> disposeCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A155A0", Offset = "0x7A13FA0", VA = "0x187A155A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A15970", Offset = "0x7A14370", VA = "0x187A15970")]
		[IteratorStateMachine(typeof(StackTimer<>.CYAVNYCNEPH))]
		public IEnumerable<(TKey, List<TKey>, TimerEntry)> VIKWSDPJHBZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A15A00", Offset = "0x7A14400", VA = "0x187A15A00")]
		[IteratorStateMachine(typeof(StackTimer<>.CXVOQRIPVDY))]
		private IEnumerable<(TKey, List<TKey>, TimerEntry)> VIKWSDPJHBZ(List<TKey> a, SIDKUMXSKTX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A156F0", Offset = "0x7A140F0", VA = "0x187A156F0")]
		private (long, int) Now()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class KLNTDGUDAVX<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b Format(StackTimer<a> timer);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected KLNTDGUDAVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class PJLEARJNRDE<a> : KLNTDGUDAVX<a, string>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x73E7460", Offset = "0x73E5E60", VA = "0x1873E7460")]
		private static string XLTZIHHPNUW(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x73E7220", Offset = "0x73E5C20", VA = "0x1873E7220", Slot = "4")]
		public override string Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x73E7090", Offset = "0x73E5A90", VA = "0x1873E7090")]
		public string Format(StackTimer<a> timer, [NotNull] KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract string AYTMBHOAYFW(StackTimer<a> a, [NotNull] KeyToStringFunc keyToStringFunc);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6F319D0", Offset = "0x6F303D0", VA = "0x186F319D0")]
		protected PJLEARJNRDE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class LZOJNFEYEMI<a> : KLNTDGUDAVX<a, Dictionary<string, string>>
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string DRFNSFPFJWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly double LJSAFOQHIXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly bool ULPSZFIDXIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly int PXEPKULSYAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ISet<string> LKZGYHSCVSV;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x68FFDB0", Offset = "0x68FE7B0", VA = "0x1868FFDB0")]
		private static string XLTZIHHPNUW(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68FFF90", Offset = "0x68FE990", VA = "0x1868FFF90")]
		public LZOJNFEYEMI(string a = "F2", double b = 1.7976931348623157E+308, bool c = false, int d = 2147483647, [Optional] ISet<string> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x68FF600", Offset = "0x68FE000", VA = "0x1868FF600", Slot = "4")]
		public override Dictionary<string, string> Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x68FE740", Offset = "0x68FD140", VA = "0x1868FE740")]
		private bool CSEYQIXEPYW(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x68FE7B0", Offset = "0x68FD1B0", VA = "0x1868FE7B0")]
		public Dictionary<string, string> Format(StackTimer<a> timer, KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x68FFC70", Offset = "0x68FE670", VA = "0x1868FFC70")]
		private string WPLPPFGUEBX(StringBuilder a, List<a> b, KeyToStringFunc c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x68FF7F0", Offset = "0x68FE1F0", VA = "0x1868FF7F0")]
		private static void MNXPWUZBGKT(StringBuilder a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class QMYSOXFXYNR<a> : PJLEARJNRDE<a>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <>c__DisplayClass4_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public KeyToStringFunc keyToStringFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static QMYSOXFXYNR<a> UIOXUQVVXGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly string[] RDLULJTAIAK;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7605250", Offset = "0x7603C50", VA = "0x187605250")]
		private QMYSOXFXYNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x76031A0", Offset = "0x7601BA0", VA = "0x1876031A0", Slot = "5")]
		protected override string AYTMBHOAYFW(StackTimer<a> a, KeyToStringFunc b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7604D80", Offset = "0x7603780", VA = "0x187604D80")]
		[CompilerGenerated]
		internal static string WITGUDTSXFC(string a, a b, <>c__DisplayClass4_0 c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class ZXMOXEXLQPA : StackTimer<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class BGYUSPZXLWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public Action<ZXMOXEXLQPA, Log> QPTYZMPRDZD;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BGYUSPZXLWP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x997AC40", Offset = "0x9979640", VA = "0x18997AC40")]
			internal void KCROXDRUVOI(StackTimer<string> a, Log b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x997F7D0", Offset = "0x997E1D0", VA = "0x18997F7D0")]
		public ZXMOXEXLQPA(Log a, [Optional] string b, [Optional] int? c, [Optional] Stopwatch d, [Optional] Action<string, TimerEntry, Log> e, [Optional] Action<string, TimerEntry, Log> f, [Optional] Action<ZXMOXEXLQPA, Log> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x997F710", Offset = "0x997E110", VA = "0x18997F710")]
		private static Action<StackTimer<string>, Log> TKXZWOGCSFQ(Action<ZXMOXEXLQPA, Log> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class PVYFZMPVXYS
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private class VZYKIEIUPAL : PVYFZMPVXYS
		{
			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static PVYFZMPVXYS UIOXUQVVXGJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x997F440", Offset = "0x997DE40", VA = "0x18997F440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override float OEPRPTJTPAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0x140ACD0", Offset = "0x14096D0", VA = "0x18140ACD0", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x997F530", Offset = "0x997DF30", VA = "0x18997F530")]
			public VZYKIEIUPAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static PVYFZMPVXYS VDCZKWZQWDD;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static PVYFZMPVXYS FYBGHSPAYRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x997CCC0", Offset = "0x997B6C0", VA = "0x18997CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract float OEPRPTJTPAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected PVYFZMPVXYS()
		{
		}
	}
}
namespace RecRoom.DataStructures.ResourceHandles
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface OVEKQGJRAJB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool DFPZNIZKTBH
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface ZTZZICZDYWU<a> : OVEKQGJRAJB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[NotNull]
		Task<a> GCWPLZCWUKH
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[NotNull]
		AUAMWGBNBSF<a> WUJPUOHRWKT
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class ROYDLWFWFYF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3E58510", Offset = "0x3E56F10", VA = "0x183E58510")]
		public static ZTZZICZDYWU<TResource> BMIXMNAHSFO<TResource, a>(this QBYHGFRJKPV<a, TResource> a, a b, [Optional] Func<a, CancellationToken, Task<TResource>>? resourceFactory) where TResource : notnull where a : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class TDAZALUXXXG
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class JAROTYKAHHU<a> : CKWORXWUSYC<a?> where a : class
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override Task<a?> GCWPLZCWUKH
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override AUAMWGBNBSF<a?> WUJPUOHRWKT
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x66CD7A0", Offset = "0x66CC1A0", VA = "0x1866CD7A0")]
			public JAROTYKAHHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "10")]
			protected override void YPJNJACYIQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class QPYVDNYGBGK<a> : CKWORXWUSYC<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private readonly a WSOYMKPGBBR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private readonly Action<a>? KBJFUPQYCSL;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public override Task<a> GCWPLZCWUKH
			{
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override AUAMWGBNBSF<a> WUJPUOHRWKT
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x7606010", Offset = "0x7604A10", VA = "0x187606010")]
			public QPYVDNYGBGK(a a, Action<a>? onDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x7605C60", Offset = "0x7604660", VA = "0x187605C60", Slot = "10")]
			protected override void YPJNJACYIQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class OZYNDFQHOJA<a> : CKWORXWUSYC<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override Task<a> GCWPLZCWUKH
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override AUAMWGBNBSF<a> WUJPUOHRWKT
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x72F3A20", Offset = "0x72F2420", VA = "0x1872F3A20")]
			public OZYNDFQHOJA(Exception a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "10")]
			protected override void YPJNJACYIQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class HAZYHUMNCRM<a> : CKWORXWUSYC<a> where a : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private struct <<-ctor>g__Unwrap|7_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public AsyncTaskMethodBuilder<a> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Task<ZTZZICZDYWU<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				private TaskAwaiter<ZTZZICZDYWU<a>> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				private TaskAwaiter<a> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x42139B0", Offset = "0x42123B0", VA = "0x1842139B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x4213F50", Offset = "0x4212950", VA = "0x184213F50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private struct <<OnDispose>g__AwaitThenDispose|8_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public Task<ZTZZICZDYWU<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				private TaskAwaiter<ZTZZICZDYWU<a>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x4218770", Offset = "0x4217170", VA = "0x184218770", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x4218E40", Offset = "0x4217840", VA = "0x184218E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private readonly Task<ZTZZICZDYWU<a>> MGAUQOWXGNA;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override Task<a> GCWPLZCWUKH
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override AUAMWGBNBSF<a> WUJPUOHRWKT
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x650FD30", Offset = "0x650E730", VA = "0x18650FD30")]
			public HAZYHUMNCRM(Task<ZTZZICZDYWU<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x650FA50", Offset = "0x650E450", VA = "0x18650FA50", Slot = "10")]
			protected override void YPJNJACYIQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x650F690", Offset = "0x650E090", VA = "0x18650F690")]
			[AsyncStateMachine(typeof(HAZYHUMNCRM<>.<<-ctor>g__Unwrap|7_0>d))]
			[CompilerGenerated]
			internal static Task<a> SLMTWTHMNIK(Task<ZTZZICZDYWU<a>> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x650F3F0", Offset = "0x650DDF0", VA = "0x18650F3F0")]
			[AsyncStateMachine(typeof(HAZYHUMNCRM<>.<<OnDispose>g__AwaitThenDispose|8_0>d))]
			[CompilerGenerated]
			internal static Task DXYYAJBPHPK(Task<ZTZZICZDYWU<a>> a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private sealed class HOOOHQPNUOK<a, b> : CKWORXWUSYC<b> where a : notnull where b : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private struct <<-ctor>g__Transform|7_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public AsyncTaskMethodBuilder<b> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public Func<a, b> transformFunc;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public Task<a> innerTask;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				private Func<a, b> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				private TaskAwaiter<a> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x4212350", Offset = "0x4210D50", VA = "0x184212350", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x4212D40", Offset = "0x4211740", VA = "0x184212D40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly ZTZZICZDYWU<a> YSTBEOHTWPF;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override Task<b> GCWPLZCWUKH
			{
				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override AUAMWGBNBSF<b> WUJPUOHRWKT
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x6529830", Offset = "0x6528230", VA = "0x186529830")]
			public HOOOHQPNUOK(ZTZZICZDYWU<a> a, Func<a, b> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x6529790", Offset = "0x6528190", VA = "0x186529790", Slot = "10")]
			protected override void YPJNJACYIQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x6529620", Offset = "0x6528020", VA = "0x186529620")]
			[AsyncStateMachine(typeof(HOOOHQPNUOK<, >.<<-ctor>g__Transform|7_0>d))]
			[CompilerGenerated]
			internal static Task<b> LLMPZBQROJB(Task<a> a, Func<a, b> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F060", Offset = "0x3F6DA60", VA = "0x183F6F060")]
		public static ZTZZICZDYWU<T> Empty<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F390", Offset = "0x3F6DD90", VA = "0x183F6F390")]
		public static ZTZZICZDYWU<T> XBQLHOMAIRZ<T>(T a, [Optional] Action<T>? onDispose) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F1A0", Offset = "0x3F6DBA0", VA = "0x183F6F1A0")]
		public static ZTZZICZDYWU<T> LBVWMBWCGET<T>(Exception a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F0C0", Offset = "0x3F6DAC0", VA = "0x183F6F0C0")]
		public static ZTZZICZDYWU<T> KJEGWQJRDML<T>(Task<ZTZZICZDYWU<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F210", Offset = "0x3F6DC10", VA = "0x183F6F210")]
		public static ZTZZICZDYWU<TOut> Transform<TOut, TIn>(ZTZZICZDYWU<TIn> handle, Func<TIn, TOut> transformFunc) where TOut : notnull where TIn : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public abstract class CKWORXWUSYC<a> : ZTZZICZDYWU<a>, OVEKQGJRAJB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static readonly string EJCSGEFRYFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DisposeReminder EWUFBGOMKSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private bool WQKINWPMPUV;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool DFPZNIZKTBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xE281C0", Offset = "0xE26BC0", VA = "0x180E281C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract Task<a> GCWPLZCWUKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public abstract AUAMWGBNBSF<a> WUJPUOHRWKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x50A2EA0", Offset = "0x50A18A0", VA = "0x1850A2EA0")]
		public CKWORXWUSYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x50A2AA0", Offset = "0x50A14A0", VA = "0x1850A2AA0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void YPJNJACYIQY();
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class CKRHURCXJMT<a, b> : CKWORXWUSYC<b> where a : Task
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class ACWIPAVUBWN
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
				public AsyncTaskMethodBuilder<b> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public a originalTask;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public ACWIPAVUBWN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x4211F10", Offset = "0x4210910", VA = "0x184211F10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x42121E0", Offset = "0x4210BE0", VA = "0x1842121E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public CKRHURCXJMT<a, b> TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public CancellationToken HVBKMCSFBAV;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ACWIPAVUBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x7212560", Offset = "0x7210F60", VA = "0x187212560")]
			[AsyncStateMachine(typeof(CKRHURCXJMT<, >.ACWIPAVUBWN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
			internal Task<b> UADVPQVSOCQ(a a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Task<b> ZIIRTARWWTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		protected readonly CancellationTokenSource SLFNIPILTVJ;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override Task<b> GCWPLZCWUKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override AUAMWGBNBSF<b> WUJPUOHRWKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x50A2370", Offset = "0x50A0D70", VA = "0x1850A2370")]
		protected CKRHURCXJMT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x50A2320", Offset = "0x50A0D20", VA = "0x1850A2320", Slot = "10")]
		protected override void YPJNJACYIQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract b LRZDFQUXBZM(a a);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void COVDAMWMAWH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class PHZARRXUQMM<a> : CKWORXWUSYC<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly WOBDLJWTCZK<Task<a>> FXQJEUFSEZO;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override Task<a> GCWPLZCWUKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xFBAA00", Offset = "0xFB9400", VA = "0x180FBAA00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override AUAMWGBNBSF<a> WUJPUOHRWKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x73E3C60", Offset = "0x73E2660", VA = "0x1873E3C60")]
		public PHZARRXUQMM(WOBDLJWTCZK<Task<a>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x73E3B50", Offset = "0x73E2550", VA = "0x1873E3B50", Slot = "10")]
		protected override void YPJNJACYIQY()
		{
		}
	}
}
namespace RecRoom.DataStructures.Hashing
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class PMERBHEBTEU
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly HashAlgorithmName BUIDCJIQKRK;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly ThreadLocal<IncrementalHash> CIOEXRNZYWV;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x997B960", Offset = "0x997A360", VA = "0x18997B960")]
		public static int DURZWGSUGOZ(this OWLJRTYPLBR a, IncrementalHash b, byte[] c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x997B600", Offset = "0x997A000", VA = "0x18997B600")]
		public static bool CHEZZUJQUTO([CanBeNull] this OWLJRTYPLBR hashableAsset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x997B660", Offset = "0x997A060", VA = "0x18997B660")]
		public static bool CHEZZUJQUTO([CanBeNull] this OWLJRTYPLBR hashableAsset, [Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x997B2F0", Offset = "0x9979CF0", VA = "0x18997B2F0")]
		public static bool CHEZZUJQUTO([CanBeNull] this OWLJRTYPLBR hashableAsset, IncrementalHash a, byte[] b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x997B9F0", Offset = "0x997A3F0", VA = "0x18997B9F0")]
		private static bool UJHBTRSLWIG(byte[] a, Span<byte> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class YBUZATNJEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x997F5C0", Offset = "0x997DFC0", VA = "0x18997F5C0")]
		public static int FADPTUBJROP(HashAlgorithmName a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4133040", Offset = "0x4131A40", VA = "0x184133040")]
		public static int DURZWGSUGOZ<a>(this a a, byte[] b, IncrementalHash c, byte[] d) where a : PCYXCBYNPOB
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface PCYXCBYNPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AppendToHash([NotNull] IncrementalHash hash);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface OWLJRTYPLBR : PCYXCBYNPOB
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[CanBeNull]
		byte[] QFAZUUNMXJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[CanBeNull]
		byte[] EZSZCWBIOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class PSIXXJPVHNO
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static bool IIOVBYFNJZM;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly ArrayPool<byte> VYVRUTUQCCB;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly ArrayPool<char> TPIHNGLIQEZ;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly Encoding KZJHAZLFFFW;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ThreadLocal<Encoder> QJCBJYOEGPF;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2020", Offset = "0x3DA0A20", VA = "0x183DA2020")]
		public static void VDOVSKZECXO<b>(this IncrementalHash a, [CanBeNull] b component) where b : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2250", Offset = "0x3DA0C50", VA = "0x183DA2250")]
		public static void XIBWKKWBYWO<c>(this IncrementalHash a, [CanBeNull] c hashable) where c : PCYXCBYNPOB
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2670", Offset = "0x3DA1070", VA = "0x183DA2670")]
		public static void ZYJPCCCFRLJ<d>(this IncrementalHash a, [CanBeNull] IList<d> hashablesList) where d : PCYXCBYNPOB
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x997C9A0", Offset = "0x997B3A0", VA = "0x18997C9A0")]
		private static bool ZEHRJFPCBER([CanBeNull] PCYXCBYNPOB hashable)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x997C5B0", Offset = "0x997AFB0", VA = "0x18997C5B0")]
		public static void YVNDGHYXFNF(this IncrementalHash a, string? stringValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x997C270", Offset = "0x997AC70", VA = "0x18997C270")]
		public static void QFJNNEBMZQQ(this IncrementalHash a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x997C3E0", Offset = "0x997ADE0", VA = "0x18997C3E0")]
		public static void TPPZJRYXSEL(this IncrementalHash a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x997BC30", Offset = "0x997A630", VA = "0x18997BC30")]
		public static void AWAZWFNHRMY(this IncrementalHash a, short b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x997BDA0", Offset = "0x997A7A0", VA = "0x18997BDA0")]
		public static void CHJEDWRRXOA(this IncrementalHash a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x997BEB0", Offset = "0x997A8B0", VA = "0x18997BEB0")]
		public static void ETNJSBEJRFB(this IncrementalHash a, bool b, bool c = false, bool d = false, bool e = false, bool f = false, bool g = false, bool h = false, bool i = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0F30", Offset = "0x3D9F930", VA = "0x183DA0F30")]
		public static void GOUGQDDBDSD<e>(this IncrementalHash a, e b) where e : struct, Enum, IConvertible
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x997C210", Offset = "0x997AC10", VA = "0x18997C210")]
		public static void OWHTVWHYDCI(this IncrementalHash a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x997C1B0", Offset = "0x997ABB0", VA = "0x18997C1B0")]
		public static void GBSACNSBKVZ(this IncrementalHash a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x997C020", Offset = "0x997AA20", VA = "0x18997C020")]
		public static void FNIQTJTJNWO(this IncrementalHash a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x997C550", Offset = "0x997AF50", VA = "0x18997C550")]
		public static void XBKECZHVYZL(this IncrementalHash a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x997C080", Offset = "0x997AA80", VA = "0x18997C080")]
		public static void FTTSMVCTSCC(this IncrementalHash a, Vector3 b)
		{
		}
	}
}
namespace RecRoom.DataStructures.Exceptions
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DataDesyncException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x997ADD0", Offset = "0x99797D0", VA = "0x18997ADD0")]
		public DataDesyncException(string message)
		{
		}
	}
}
namespace RecRoom.Core.Scripts.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class GSELZZBUXCS
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate void OnStateChange(ushort currentStateId, ushort previousStateId, ushort currentSubStateId, ushort previousSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate void StateTransition(ushort otherStateId, ushort otherSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public delegate void StateUpdate();

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public const ushort UATUDSSBVTX = 65535;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected GSELZZBUXCS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class NFUNFFQLART<a> : GSELZZBUXCS where a : NFUNFFQLART<a>.OPFDZVFSQFU
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public interface OPFDZVFSQFU
		{
			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			StateTransition KBUFEMLANXZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			StateTransition BNRKEXQNFNZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			StateUpdate SHNXQNXKPIK
			{
				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<uint, a> JPCCIOQDFGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private StateUpdate ZBJRFEJFOTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private StateUpdate LAHTYGQHRJN;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool YAGPPRKVGGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xD14CD0", Offset = "0xD136D0", VA = "0x180D14CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ushort SNKAXEAHOLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x12E0090", Offset = "0x12DEA90", VA = "0x1812E0090")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x12E0580", Offset = "0x12DEF80", VA = "0x1812E0580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public ushort IODMMGAYTPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x714CE60", Offset = "0x714B860", VA = "0x18714CE60")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x714CCF0", Offset = "0x714B6F0", VA = "0x18714CCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ushort CVNZBKXVXDX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xF86D40", Offset = "0xF85740", VA = "0x180F86D40")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xF86E90", Offset = "0xF85890", VA = "0x180F86E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ushort LLYSEAKIUCR
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x714B6B0", Offset = "0x714A0B0", VA = "0x18714B6B0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x714B500", Offset = "0x7149F00", VA = "0x18714B500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected bool XOWGKAMUKDW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x12E03D0", Offset = "0x12DEDD0", VA = "0x1812E03D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected bool DETBORQMREH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1B1D550", Offset = "0x1B1BF50", VA = "0x181B1D550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OnStateChange HTGYXWHTPDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x714B260", Offset = "0x7149C60", VA = "0x18714B260")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x714B460", Offset = "0x7149E60", VA = "0x18714B460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x714C980", Offset = "0x714B380", VA = "0x18714C980")]
		private a NGHHPXNSAWO(ushort a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x714CE70", Offset = "0x714B870", VA = "0x18714CE70")]
		private a TXTEEZAFPLL(ushort a, ushort b)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x714CD00", Offset = "0x714B700", VA = "0x18714CD00")]
		protected a SPESWKBOFND(uint a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x714D180", Offset = "0x714BB80", VA = "0x18714D180")]
		protected NFUNFFQLART()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x714CB40", Offset = "0x714B540", VA = "0x18714CB40")]
		public void OKHGRCVRKBD(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x714CB60", Offset = "0x714B560", VA = "0x18714CB60")]
		public void OKHGRCVRKBD(ushort a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x714CBF0", Offset = "0x714B5F0", VA = "0x18714CBF0", Slot = "4")]
		protected virtual void OKHGRCVRKBD(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x714B6D0", Offset = "0x714A0D0", VA = "0x18714B6D0")]
		protected void MAETUVPHBJF(uint a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x714B510", Offset = "0x7149F10", VA = "0x18714B510")]
		protected void IDPOFWOIKJR(ushort a, ushort b, a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x714D040", Offset = "0x714BA40", VA = "0x18714D040")]
		private void WYFHCJJITTT(uint a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x714B0E0", Offset = "0x7149AE0", VA = "0x18714B0E0")]
		protected void BGUGGUOGMCZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x714B6C0", Offset = "0x714A0C0", VA = "0x18714B6C0")]
		protected uint KKEQVAWBEWY(ushort a, ushort b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x714B3A0", Offset = "0x7149DA0", VA = "0x18714B3A0")]
		protected ushort DMDJELADDYQ(uint a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x714B3B0", Offset = "0x7149DB0", VA = "0x18714B3B0")]
		protected ushort FNUCVHDPWPB(uint a)
		{
			return default(ushort);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class HIHZSDYXYHX : NFUNFFQLART<HIHZSDYXYHX.State>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class State : OPFDZVFSQFU
		{
			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public StateTransition KBUFEMLANXZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public StateTransition BNRKEXQNFNZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public StateUpdate SHNXQNXKPIK
			{
				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x997AEB0", Offset = "0x99798B0", VA = "0x18997AEB0")]
		public void NEHOMIIDJRY(ushort a, StateTransition b, StateTransition c, StateUpdate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x997AF90", Offset = "0x9979990", VA = "0x18997AF90")]
		public void NEHOMIIDJRY(ushort a, ushort b, StateTransition c, StateTransition d, StateUpdate e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x997B070", Offset = "0x9979A70", VA = "0x18997B070")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x997B0C0", Offset = "0x9979AC0", VA = "0x18997B0C0")]
		protected HIHZSDYXYHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class KJXDSNOYYOP : HIHZSDYXYHX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool BQVHFDRBTXB;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xF8B000", Offset = "0xF89A00", VA = "0x180F8B000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xF8A960", Offset = "0xF89360", VA = "0x180F8A960")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x997B160", Offset = "0x9979B60", VA = "0x18997B160")]
		public void Initialize(ushort initialStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x997B100", Offset = "0x9979B00", VA = "0x18997B100")]
		public void Initialize(ushort initialStateId, ushort initialSubStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x997B0C0", Offset = "0x9979AC0", VA = "0x18997B0C0")]
		public KJXDSNOYYOP()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class WMFSKOTVILG<a, b> : IDisposable where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal class YMJNEKIXRQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public b PDRVWYXAVWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public b CVRJANTESXQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public PriorityClaim GXTZTHXXLWB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public List<PriorityClaim> JIAKUNATETC;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public YMJNEKIXRQO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		internal struct PriorityClaim : IComparable<PriorityClaim>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public int priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public a claim;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x19C1B20", Offset = "0x19C0520", VA = "0x1819C1B20")]
			public PriorityClaim(int priority, a claim)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x75ACAE0", Offset = "0x75AB4E0", VA = "0x1875ACAE0")]
			public bool UMMQBLDMMRJ([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x75ACA70", Offset = "0x75AB470", VA = "0x1875ACA70")]
			public bool OWGHJZJGQZM([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x75ACA60", Offset = "0x75AB460", VA = "0x1875ACA60", Slot = "4")]
			public int CompareTo(PriorityClaim other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x75ACA80", Offset = "0x75AB480", VA = "0x1875ACA80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			FirstOwner,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			ClosestAncestor
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class JYQFDXVRBRM : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private b RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private b CJLJOPNYWCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public b DSUDGWOIYIU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public WMFSKOTVILG<a, b> TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private b JJQXQMMGHQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public b ZJSWLQWZVHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private bool BFYGHIBPFJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public bool NUFADKBDKUA;

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			private b UUHSMHMKPPH
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public JYQFDXVRBRM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x66E2E90", Offset = "0x66E1890", VA = "0x1866E2E90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x66E2DB0", Offset = "0x66E17B0", VA = "0x1866E2DB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> IOBVGKOVBOW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x66E2F70", Offset = "0x66E1970", VA = "0x1866E2F70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly KQPXNAVSSTH<YMJNEKIXRQO> MUTQIMDQKIA;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly KQPXNAVSSTH<List<PriorityClaim>> EEFTUDHUKPS;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static int UIUTREKEYYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		internal readonly Dictionary<a, b> WSTFBDNIDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		internal readonly Dictionary<b, YMJNEKIXRQO> RZBGFBLTXDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mode WKNQHFNLLEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool JHVCKNKMFHD;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract b GYJEZGJLXWC(b a);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void EDTYGBOGEOK(b a, a b, a c);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x87376A0", Offset = "0x87360A0", VA = "0x1887376A0")]
		public WMFSKOTVILG(Mode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8736BC0", Offset = "0x87355C0", VA = "0x188736BC0")]
		public void TBLZOGTWDMT(b a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8736970", Offset = "0x8735370", VA = "0x188736970")]
		public void RQQKSQZHQRZ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8735C70", Offset = "0x8734670", VA = "0x188735C70", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x87368D0", Offset = "0x87352D0", VA = "0x1887368D0")]
		private void QHALKEMKJEA(a a, b b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8736230", Offset = "0x8734C30", VA = "0x188736230")]
		private int KHHHQJHSYUU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8736370", Offset = "0x8734D70", VA = "0x188736370")]
		private void KVGUGNMMQWJ(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8736AD0", Offset = "0x87354D0", VA = "0x188736AD0")]
		private void SOPOTKOTPXU(PriorityClaim a, YMJNEKIXRQO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8736C40", Offset = "0x8735640", VA = "0x188736C40")]
		private void UDVFMMFBDFP(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8737190", Offset = "0x8735B90", VA = "0x188737190")]
		private void YUVWTRQKLZI(PriorityClaim a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8736160", Offset = "0x8734B60", VA = "0x188736160")]
		private void JMYWPEYSMXA(PriorityClaim a, YMJNEKIXRQO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8737080", Offset = "0x8735A80", VA = "0x188737080")]
		private void XJCCSVYYSUD(YMJNEKIXRQO a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8735E40", Offset = "0x8734840", VA = "0x188735E40")]
		private void EEBMXHPFDLV(YMJNEKIXRQO a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8736290", Offset = "0x8734C90", VA = "0x188736290")]
		[IteratorStateMachine(typeof(WMFSKOTVILG<, >.JYQFDXVRBRM))]
		private IEnumerable<b> KPBLMIZQENV(b a, b b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8735AA0", Offset = "0x87344A0", VA = "0x188735AA0")]
		private YMJNEKIXRQO AOXRQDCBPTF(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8736F40", Offset = "0x8735940", VA = "0x188736F40")]
		private YMJNEKIXRQO VVXICTTCLKW(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8736760", Offset = "0x8735160", VA = "0x188736760")]
		private void OAWKDHNLROM(YMJNEKIXRQO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TZQRYKARDKQ<a> : IEnumerable<TZQRYKARDKQ<a>.Pair>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public struct Pair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public a value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public int index;
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public class WVSTUJCAFPO : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private TZQRYKARDKQ<a> XVTQEQRCFCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private int SCOEDYFFAIK;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x8749540", Offset = "0x8747F40", VA = "0x188749540", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x87498E0", Offset = "0x87482E0", VA = "0x1887498E0", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x87495A0", Offset = "0x8747FA0", VA = "0x1887495A0")]
			public WVSTUJCAFPO(TZQRYKARDKQ<a> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x8749470", Offset = "0x8747E70", VA = "0x188749470", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x5BEE770", Offset = "0x5BED170", VA = "0x185BEE770", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xF8A2E0", Offset = "0xF88CE0", VA = "0x180F8A2E0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private struct ListEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public bool hasValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public a value;
		}

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private const int YNDNOABXHPW = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly Dictionary<a, int> AWONXKHSJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ListEntry[] UOZQIYBTANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int VSGDWVOTVUP;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int RIGYEMVVXDW
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xD39090", Offset = "0xD37A90", VA = "0x180D39090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xF22B20", Offset = "0xF21520", VA = "0x180F22B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D3A0", Offset = "0x7A6BDA0", VA = "0x187A6D3A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D3D0", Offset = "0x7A6BDD0", VA = "0x187A6D3D0")]
		public TZQRYKARDKQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D4A0", Offset = "0x7A6BEA0", VA = "0x187A6D4A0")]
		public TZQRYKARDKQ(Pair[] a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CFE0", Offset = "0x7A6B9E0", VA = "0x187A6CFE0")]
		public int PEIDKOGSODP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CD10", Offset = "0x7A6B710", VA = "0x187A6CD10")]
		private int AYAZOYYUHWC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D0D0", Offset = "0x7A6BAD0", VA = "0x187A6D0D0", Slot = "6")]
		protected virtual uint TKGSROURAKG(uint a, a b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D090", Offset = "0x7A6BA90", VA = "0x187A6D090")]
		public bool TFHHJQVIRMM(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CF80", Offset = "0x7A6B980", VA = "0x187A6CF80")]
		public int OMVUCJYLTKG(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CF10", Offset = "0x7A6B910", VA = "0x187A6CF10")]
		public a KHJQRGNTLDB(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D100", Offset = "0x7A6BB00", VA = "0x187A6D100")]
		public bool UOHDBVFAYZI(a a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D140", Offset = "0x7A6BB40", VA = "0x187A6D140")]
		public bool UOHDBVFAYZI(a a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D350", Offset = "0x7A6BD50", VA = "0x187A6D350")]
		private int WBZUQSGMBHB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D010", Offset = "0x7A6BA10", VA = "0x187A6D010", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D010", Offset = "0x7A6BA10", VA = "0x187A6D010", Slot = "4")]
		private IEnumerator<Pair> PIGJRIVALAJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class KQPXNAVSSTH<a> : IDisposable where a : new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Stack<a> GUWLFXZNXIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<a> LPILAKBVNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly int NYZYPZYBHNZ;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x67EBEF0", Offset = "0x67EA8F0", VA = "0x1867EBEF0")]
		public static KQPXNAVSSTH<a> EQCQGSDZQKJ(int a = 0, int b = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x67ECF20", Offset = "0x67EB920", VA = "0x1867ECF20")]
		public KQPXNAVSSTH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x67ECB70", Offset = "0x67EB570", VA = "0x1867ECB70")]
		public KQPXNAVSSTH(int a, int b = 2147483647, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x67EB780", Offset = "0x67EA180", VA = "0x1867EB780")]
		public a Acquire()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x67EC890", Offset = "0x67EB290", VA = "0x1867EC890")]
		public void Release(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x67EC080", Offset = "0x67EAA80", VA = "0x1867EC080")]
		private void LWEIYMEMPRG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x67EC800", Offset = "0x67EB200", VA = "0x1867EC800")]
		private void RHFAFMSRHDZ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x67EBDD0", Offset = "0x67EA7D0", VA = "0x1867EBDD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x67EC2D0", Offset = "0x67EACD0", VA = "0x1867EC2D0")]
		private void QXZCUCAOZUQ(IEnumerable<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class GWHWNGTGUUH<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private Dictionary<int, a> FBYXNPGHACW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private a VBZFUSCRIBA;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual a THURQTQHAAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xD68720", Offset = "0xD67120", VA = "0x180D68720", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x14224C0", Offset = "0x1420EC0", VA = "0x1814224C0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x647A300", Offset = "0x6478D00", VA = "0x18647A300")]
		public bool GTGGKRFOHOK(a a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x647A1F0", Offset = "0x6478BF0", VA = "0x18647A1F0")]
		public bool FDFKFMKSKNJ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x647A940", Offset = "0x6479340", VA = "0x18647A940")]
		public a QELCDSZPRFB(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6479E60", Offset = "0x6478860", VA = "0x186479E60")]
		private bool BNOUDTKHBBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x647A570", Offset = "0x6478F70", VA = "0x18647A570")]
		public bool MAVXVFMPMHQ(int a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x647ABD0", Offset = "0x64795D0", VA = "0x18647ABD0")]
		public GWHWNGTGUUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class OWOMJFMJVPY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		protected struct Entry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public a Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public int Priority;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		protected readonly List<Entry> IPPCTJYFWCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private a VGWTXJLVHRV;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x286EF10", Offset = "0x286D910", VA = "0x18286EF10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x72F0D60", Offset = "0x72EF760", VA = "0x1872F0D60")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x72F0A40", Offset = "0x72EF440", VA = "0x1872F0A40")]
		public void Add(a value, int priority)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x72F1D60", Offset = "0x72F0760", VA = "0x1872F1D60")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x72F0C30", Offset = "0x72EF630", VA = "0x1872F0C30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x72F24C0", Offset = "0x72F0EC0", VA = "0x1872F24C0")]
		public a ZRFAOMUSEEB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x72F1760", Offset = "0x72F0160", VA = "0x1872F1760")]
		protected void IWISJHJRRXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x72F25E0", Offset = "0x72F0FE0", VA = "0x1872F25E0")]
		public OWOMJFMJVPY()
		{
		}
	}
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
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x997CF70", Offset = "0x997B970", VA = "0x18997CF70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x997D240", Offset = "0x997BC40", VA = "0x18997D240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x997D150", Offset = "0x997BB50", VA = "0x18997D150")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x997CEC0", Offset = "0x997B8C0", VA = "0x18997CEC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x997D190", Offset = "0x997BB90", VA = "0x18997D190")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x997D0A0", Offset = "0x997BAA0", VA = "0x18997D0A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x997CE30", Offset = "0x997B830", VA = "0x18997CE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x78A9D30", Offset = "0x78A8730", VA = "0x1878A9D30", Slot = "4")]
		public virtual T ZPVWSERUUCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected ResourcePrefabReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface ANEHKSMNGNW
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		ToolHierarchyCache UWRNPHBAFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public struct Enumerable<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool includeInactive;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1B2BE00", Offset = "0x1B2A800", VA = "0x181B2BE00")]
			public Enumerable(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCD80", Offset = "0x5BCB780", VA = "0x185BCCD80")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCC60", Offset = "0x5BCB660", VA = "0x185BCCC60", Slot = "5")]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCC60", Offset = "0x5BCB660", VA = "0x185BCCC60", Slot = "4")]
			private IEnumerator<T> EZYGKGYZAUK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public struct Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool includeInactive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public T Current
			{
				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x5CB4EA0", Offset = "0x5CB38A0", VA = "0x185CB4EA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x5CB47A0", Offset = "0x5CB31A0", VA = "0x185CB47A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x5CB49C0", Offset = "0x5CB33C0", VA = "0x185CB49C0")]
			public Enumerator(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x5CB3520", Offset = "0x5CB1F20", VA = "0x185CB3520", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x5CB4580", Offset = "0x5CB2F80", VA = "0x185CB4580", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x5BB3BA0", Offset = "0x5BB25A0", VA = "0x185BB3BA0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> VZXKSDIPVPX;

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
		private Dictionary<Type, List<Component>> IYHMENKXJYR;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x997F110", Offset = "0x997DB10", VA = "0x18997F110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x997EF10", Offset = "0x997D910", VA = "0x18997EF10")]
		private void Initialize(GameObject go, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x997EE80", Offset = "0x997D880", VA = "0x18997EE80")]
		public static void Initialize(GameObject go, ToolHierarchyCache cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x997F070", Offset = "0x997DA70", VA = "0x18997F070")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3F878E0", Offset = "0x3F862E0", VA = "0x183F878E0")]
		public void ADJXGPFRARW<a>(Action<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3F87AA0", Offset = "0x3F864A0", VA = "0x183F87AA0")]
		public b BQDMSLFMFWF<b>(bool a = false) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3F87B90", Offset = "0x3F86590", VA = "0x183F87B90")]
		public Enumerable<c> KNWRSEHDFOG<c>(bool a = false) where c : class
		{
			return default(Enumerable<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x997EA90", Offset = "0x997D490", VA = "0x18997EA90")]
		public List<Component> GNSMQCJUZMZ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x997EA10", Offset = "0x997D410", VA = "0x18997EA10", Slot = "4")]
		public bool Equals(ToolHierarchyCache x, ToolHierarchyCache y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x997EE10", Offset = "0x997D810", VA = "0x18997EE10", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache obj)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class VNQEFRYCKAS<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private int CHJRVNMSUUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int TBPRRQOXMLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private List<a> GAZJONTSFSH;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x27F4730", Offset = "0x27F3130", VA = "0x1827F4730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public a WNQXMBRTZCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7F72630", Offset = "0x7F71030", VA = "0x187F72630")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public a VARJBJTJXIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7F72C30", Offset = "0x7F71630", VA = "0x187F72C30")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public a PWKLJASCPTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x7F72A80", Offset = "0x7F71480", VA = "0x187F72A80")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7F72F40", Offset = "0x7F71940", VA = "0x187F72F40")]
		public VNQEFRYCKAS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7F724A0", Offset = "0x7F70EA0", VA = "0x187F724A0")]
		public void Add(a command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7F72830", Offset = "0x7F71230", VA = "0x187F72830")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7F72EB0", Offset = "0x7F718B0", VA = "0x187F72EB0")]
		public void UVSKMEIXPYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7F72D00", Offset = "0x7F71700", VA = "0x187F72D00")]
		public void PBMRVZKDZPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7F728F0", Offset = "0x7F712F0", VA = "0x187F728F0")]
		public void EAUGMTCGPUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7F720E0", Offset = "0x7F70AE0", VA = "0x187F720E0")]
		public List<a> ABNOPIKGNCD()
		{
			return null;
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class QXQDNGXEBQE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private struct PrioritizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public int Priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly Dictionary<object, PrioritizedData> FBYXNPGHACW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly EqualityComparer<a> VFTRKALHYCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private a VBZFUSCRIBA;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual a THURQTQHAAL
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xEF3310", Offset = "0xEF1D10", VA = "0x180EF3310", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7616E50", Offset = "0x7615850", VA = "0x187616E50", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool CUTXDDWMFUV
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7616D40", Offset = "0x7615740", VA = "0x187616D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public object XMWWFCDVAHB
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7615F30", Offset = "0x7614930", VA = "0x187615F30")]
		public bool GTGGKRFOHOK(a a, object b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x76150C0", Offset = "0x7613AC0", VA = "0x1876150C0")]
		public bool FDFKFMKSKNJ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x76169B0", Offset = "0x76153B0", VA = "0x1876169B0")]
		public bool MAVXVFMPMHQ(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7614B70", Offset = "0x7613570", VA = "0x187614B70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7613560", Offset = "0x7611F60", VA = "0x187613560")]
		private bool BNOUDTKHBBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7617510", Offset = "0x7615F10", VA = "0x187617510")]
		public QXQDNGXEBQE()
		{
		}
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
