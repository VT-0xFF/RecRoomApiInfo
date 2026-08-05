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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84C8240", Offset = "0x84C6840", VA = "0x1884C8240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CompactArrayDrawerAttribute : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2472840", Offset = "0x2470E40", VA = "0x182472840")]
	public CompactArrayDrawerAttribute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, ILEAYNPSJIV, SNNCNTNADPN, ISerializationCallbackReceiver
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
	public byte[] FKCFSQMJZGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] CJWBONVVFMZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object UTSUQOAALKY
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash hash);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xDB5160", Offset = "0xDB3760", VA = "0x180DB5160")]
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
	private float GGWUSFUPNQP;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float RIHAOYWXZTQ;

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
		[Cpp2IlInjected.Address(RVA = "0x84C9740", Offset = "0x84C7D40", VA = "0x1884C9740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84C9700", Offset = "0x84C7D00", VA = "0x1884C9700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84C9780", Offset = "0x84C7D80", VA = "0x1884C9780")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84C98A0", Offset = "0x84C7EA0", VA = "0x1884C98A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84C9800", Offset = "0x84C7E00", VA = "0x1884C9800")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAFB210", Offset = "0xAF9810", VA = "0x180AFB210")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAFA720", Offset = "0xAF8D20", VA = "0x180AFA720")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84C96E0", Offset = "0x84C7CE0", VA = "0x1884C96E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF28F30", Offset = "0xF27530", VA = "0x180F28F30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84C90C0", Offset = "0x84C76C0", VA = "0x1884C90C0")]
	public void CopyBounds(SavedExtents other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84C9440", Offset = "0x84C7A40", VA = "0x1884C9440")]
	public void SetLocalSpaceBounds(Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1765A00", Offset = "0x1764000", VA = "0x181765A00")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84C9430", Offset = "0x84C7A30", VA = "0x1884C9430")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84C9460", Offset = "0x84C7A60", VA = "0x1884C9460")]
	private void WELJEAKDYZS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84C91B0", Offset = "0x84C77B0", VA = "0x1884C91B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84C8AA0", Offset = "0x84C70A0", VA = "0x1884C8AA0")]
	public static void CalculateLocalBoundsFor(GameObject gameObject, [Out] Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84C90F0", Offset = "0x84C76F0", VA = "0x1884C90F0")]
	private static void KYRVRFSEUKH(Bounds a, Color b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84C9660", Offset = "0x84C7C60", VA = "0x1884C9660")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C44D60", Offset = "0x1C43360", VA = "0x181C44D60")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6060550", Offset = "0x605EB50", VA = "0x186060550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
	public virtual void MMOOQNRPEYQ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x605E120", Offset = "0x605C720", VA = "0x18605E120", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x605CFD0", Offset = "0x605B5D0", VA = "0x18605CFD0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x605E460", Offset = "0x605CA60", VA = "0x18605E460")]
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
	private sealed class QEFUBVWJVIW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> JQIUYWFAJFZ;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public QEFUBVWJVIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFB750", Offset = "0x5CF9D50", VA = "0x185CFB750")]
		internal int NQYDUUZROUW(TKeyVal a, TKeyVal b)
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
	private readonly Dictionary<TKey, TVal> CDYSGHFXHJI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4955BD0", Offset = "0x49541D0", VA = "0x184955BD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4955C40", Offset = "0x4954240", VA = "0x184955C40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4955960", Offset = "0x4953F60", VA = "0x184955960", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey key]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4955A00", Offset = "0x4954000", VA = "0x184955A00", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> OTEODZDSELL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x49540F0", Offset = "0x49526F0", VA = "0x1849540F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49553D0", Offset = "0x49539D0", VA = "0x1849553D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4954790", Offset = "0x4952D90", VA = "0x184954790", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x49546D0", Offset = "0x4952CD0", VA = "0x1849546D0", Slot = "14")]
	protected virtual string ISIRLRCIAFH(TKeyVal a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x49544E0", Offset = "0x4952AE0", VA = "0x1849544E0", Slot = "4")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4955560", Offset = "0x4953B60", VA = "0x184955560", Slot = "5")]
	public bool TryGetValue(TKey key, [Out] TVal value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x49545B0", Offset = "0x4952BB0", VA = "0x1849545B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49545B0", Offset = "0x4952BB0", VA = "0x1849545B0", Slot = "11")]
	private IEnumerator MZPFIUHPQEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4955890", Offset = "0x4953E90", VA = "0x184955890")]
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
		[Cpp2IlInjected.Address(RVA = "0xF396D0", Offset = "0xF37CD0", VA = "0x180F396D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF396F0", Offset = "0xF37CF0", VA = "0x180F396F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6062730", Offset = "0x6060D30", VA = "0x186062730")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x60623C0", Offset = "0x60609C0", VA = "0x1860623C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6061AA0", Offset = "0x60600A0", VA = "0x186061AA0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class JOEXGLMBTAP<a>
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
	private const int OOESOZUWBMO = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float QFWAYYALFEB = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly BufferEntry[] CIQNPPAWWXH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int FFKPJXLAAQK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float DPGKHBSMWNQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xE11DF0", Offset = "0xE103F0", VA = "0x180E11DF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE55F90", Offset = "0xE54590", VA = "0x180E55F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public a NTLPMDPMHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1A080E0", Offset = "0x1A066E0", VA = "0x181A080E0")]
		[CompilerGenerated]
		get
		{
			return (a)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x52BDDC0", Offset = "0x52BC3C0", VA = "0x1852BDDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x52BDFA0", Offset = "0x52BC5A0", VA = "0x1852BDFA0")]
	protected JOEXGLMBTAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x52BDEE0", Offset = "0x52BC4E0", VA = "0x1852BDEE0")]
	protected JOEXGLMBTAP(int a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x52BDB00", Offset = "0x52BC100", VA = "0x1852BDB00")]
	public void Add(float time, a value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool OGNRGGZKGQM(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JSISUDMZTXR(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x52BDD00", Offset = "0x52BC300", VA = "0x1852BDD00")]
	public void Clear()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class VVJMDFRINPK : JOEXGLMBTAP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84CB460", Offset = "0x84C9A60", VA = "0x1884CB460", Slot = "4")]
	public override bool OGNRGGZKGQM(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84CB320", Offset = "0x84C9920", VA = "0x1884CB320", Slot = "5")]
	public override bool JSISUDMZTXR(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84CB5C0", Offset = "0x84C9BC0", VA = "0x1884CB5C0")]
	public VVJMDFRINPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D796A0", Offset = "0x3D77CA0", VA = "0x183D796A0")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D797A0", Offset = "0x3D77DA0", VA = "0x183D797A0")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5A55A60", Offset = "0x5A54060", VA = "0x185A55A60")]
	internal static int EUUEWZPXPVX(int a, int b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7682F80", Offset = "0x7681580", VA = "0x187682F80")]
	internal static int EUUEWZPXPVX(int a, int b, int c)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class Tuple<T1, T2> : IComparable<Tuple<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 ZPLCEBEFCJY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 ZPFVGUKHSYP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6341F00", Offset = "0x6340500", VA = "0x186341F00")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x63391B0", Offset = "0x63377B0", VA = "0x1863391B0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x633A700", Offset = "0x6338D00", VA = "0x18633A700", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x633AD20", Offset = "0x6339320", VA = "0x18633AD20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6341680", Offset = "0x633FC80", VA = "0x186341680", Slot = "3")]
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
	public readonly T1 ZPLCEBEFCJY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 ZPFVGUKHSYP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 ZPAOJNQKJNG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6345FE0", Offset = "0x63445E0", VA = "0x186345FE0")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6341F40", Offset = "0x6340540", VA = "0x186341F40", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63426B0", Offset = "0x6340CB0", VA = "0x1863426B0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6342F70", Offset = "0x6341570", VA = "0x186342F70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6345E70", Offset = "0x6344470", VA = "0x186345E70", Slot = "3")]
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
	public AnimationCurve VEYUXIHMRNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T IVHYRAKDBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E30", Offset = "0x14A2430", VA = "0x1814A3E30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T AYSVNBTBKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HOYELULZOXT
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2F6C050", Offset = "0x2F6A650", VA = "0x182F6C050")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2F6C120", Offset = "0x2F6A720", VA = "0x182F6C120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float URCAKTIPEVO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xDF7B30", Offset = "0xDF6130", VA = "0x180DF7B30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x65A0830", Offset = "0x659EE30", VA = "0x1865A0830")]
	public T MWNGZVRCITN(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x65A0180", Offset = "0x659E780", VA = "0x1865A0180")]
	public T DTVJUDRTJOH(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LXHSZKGVJVZ(T a, T b, float c);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84C7C30", Offset = "0x84C6230", VA = "0x1884C7C30", Slot = "4")]
	protected override float LXHSZKGVJVZ(float a, float b, float c)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84C7C70", Offset = "0x84C6270", VA = "0x1884C7C70")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1AA03E0", Offset = "0x1A9E9E0", VA = "0x181AA03E0", Slot = "4")]
	protected override Vector3 LXHSZKGVJVZ(Vector3 a, Vector3 b, float c)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84CB600", Offset = "0x84C9C00", VA = "0x1884CB600")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84C7A60", Offset = "0x84C6060", VA = "0x1884C7A60", Slot = "4")]
	protected override Color LXHSZKGVJVZ(Color a, Color b, float c)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84C7B20", Offset = "0x84C6120", VA = "0x1884C7B20")]
	public ColorValueCurve()
	{
	}
}
namespace Structures.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class OPVOKHIQSBU : AQJIXPNABGW<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84C8330", Offset = "0x84C6930", VA = "0x1884C8330")]
		public OPVOKHIQSBU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84C82C0", Offset = "0x84C68C0", VA = "0x1884C82C0", Slot = "6")]
		protected override uint HLLFKAATUGY(uint a, string b)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class FVUWPDSEUZQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly IDisposable ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public FVUWPDSEUZQ()
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
		[Cpp2IlInjected.Address(RVA = "0x5A58450", Offset = "0x5A56A50", VA = "0x185A58450")]
		private AwaitableRpc(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> roundTripRequests, int lastActorId, int requestId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7204880", Offset = "0x7202E80", VA = "0x187204880")]
		public static AwaitableRpc<T> New()
		{
			return default(AwaitableRpc<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7203620", Offset = "0x7201C20", VA = "0x187203620")]
		public (int, int, Task<T>) HNMYZOKXTVH(int a, [Optional] CancellationToken b, double c = 60.0)
		{
			return default((int, int, Task<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72045E0", Offset = "0x7202BE0", VA = "0x1872045E0")]
		public void ITXVNRMZVLO(int a, int b, [In] T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class UFLQGXEMUCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84CA810", Offset = "0x84C8E10", VA = "0x1884CA810")]
		public static AwaitableRpc<None> New()
		{
			return default(AwaitableRpc<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84CA790", Offset = "0x84C8D90", VA = "0x1884CA790")]
		public static void ITXVNRMZVLO([In] this AwaitableRpc<None> self, int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DBORJULKVGN<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Dictionary<a, b> CTRMBFEQZYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Dictionary<b, a> ZOCQSKDHNHF;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4312AC0", Offset = "0x43110C0", VA = "0x184312AC0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4312ED0", Offset = "0x43114D0", VA = "0x184312ED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x4312F80", Offset = "0x4311580", VA = "0x184312F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4312AF0", Offset = "0x43110F0", VA = "0x184312AF0", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4313050", Offset = "0x4311650", VA = "0x184313050", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public a this[b key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4312E70", Offset = "0x4311470", VA = "0x184312E70")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4311390", Offset = "0x430F990", VA = "0x184311390", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4311A70", Offset = "0x4310070", VA = "0x184311A70", Slot = "20")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4310CC0", Offset = "0x430F2C0", VA = "0x184310CC0", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4310E40", Offset = "0x430F440", VA = "0x184310E40", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4311420", Offset = "0x430FA20", VA = "0x184311420", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4311560", Offset = "0x430FB60", VA = "0x184311560", Slot = "16")]
		public bool Contains(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4311EE0", Offset = "0x43104E0", VA = "0x184311EE0", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4311EE0", Offset = "0x43104E0", VA = "0x184311EE0", Slot = "18")]
		public bool Remove(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4312120", Offset = "0x4310720", VA = "0x184312120", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x43118C0", Offset = "0x430FEC0", VA = "0x1843118C0", Slot = "19")]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4311740", Offset = "0x430FD40", VA = "0x184311740", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4312810", Offset = "0x4310E10", VA = "0x184312810")]
		public bool ZKJFYFPTSEI(b a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4310FB0", Offset = "0x430F5B0", VA = "0x184310FB0")]
		private void BUHPTGVTAMK(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4311B60", Offset = "0x4310160", VA = "0x184311B60")]
		private void OPRKEVYRFOB(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4312510", Offset = "0x4310B10", VA = "0x184312510")]
		private bool VMQDGGWNTWB(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4312920", Offset = "0x4310F20", VA = "0x184312920")]
		public DBORJULKVGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class FOZTKRHDPJK<a> : IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private FOZTKRHDPJK<a> buffer;

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
				[Cpp2IlInjected.Address(RVA = "0x4972030", Offset = "0x4970630", VA = "0x184972030", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x4981E90", Offset = "0x4980490", VA = "0x184981E90", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x4984460", Offset = "0x4982A60", VA = "0x184984460")]
			public Enumerator(FOZTKRHDPJK<a> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4982910", Offset = "0x4980F10", VA = "0x184982910", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4984250", Offset = "0x4982850", VA = "0x184984250", Slot = "8")]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x4981C40", Offset = "0x4980240", VA = "0x184981C40")]
			private void CLPAXBZFKNK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private a[] GKQIFBVLYMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int KNAVBOLYRXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int CDJMTQYXQVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int version;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4F3ACA0", Offset = "0x4F392A0", VA = "0x184F3ACA0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4F3AEF0", Offset = "0x4F394F0", VA = "0x184F3AEF0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4F3B000", Offset = "0x4F39600", VA = "0x184F3B000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4F3ABA0", Offset = "0x4F391A0", VA = "0x184F3ABA0")]
		public FOZTKRHDPJK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4F37E90", Offset = "0x4F36490", VA = "0x184F37E90")]
		public void Add(a t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4F39A30", Offset = "0x4F38030", VA = "0x184F39A30")]
		public void EIIARTIDLHW(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4F38650", Offset = "0x4F36C50", VA = "0x184F38650")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A890", Offset = "0x4F38E90", VA = "0x184F3A890")]
		public void JMICSQCHABV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4F38670", Offset = "0x4F36C70", VA = "0x184F38670")]
		public void CopyTo(a[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A6B0", Offset = "0x4F38CB0", VA = "0x184F3A6B0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4F385A0", Offset = "0x4F36BA0", VA = "0x184F385A0", Slot = "4")]
		private IEnumerator<a> CDFQCYMHDZO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4F385A0", Offset = "0x4F36BA0", VA = "0x184F385A0", Slot = "5")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A9E0", Offset = "0x4F38FE0", VA = "0x184F3A9E0")]
		private int TCLCSWPVNQB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A9B0", Offset = "0x4F38FB0", VA = "0x184F3A9B0")]
		private int PLSTQFJNCBH(int a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class IYWOPWKMZEF<a, b> : IDisposable
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
		public class IMGHHNHTBXY
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private const float SOGPOIIHQTS = 60f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TimeSpan UNPYBZFILPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int CXQDBTTSGXQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ProcessMethod VFADOSDZJQU;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly IMGHHNHTBXY AMLVLGFTEOB;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public float ARESUOZTAQD
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x51DA140", Offset = "0x51D8740", VA = "0x1851DA140")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public TimeSpan NBGQAFZAQTK
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				get
				{
					return default(TimeSpan);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x51DA560", Offset = "0x51D8B60", VA = "0x1851DA560")]
			public IMGHHNHTBXY()
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
			[Cpp2IlInjected.Address(RVA = "0x5D1C250", Offset = "0x5D1A850", VA = "0x185D1C250")]
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
			public IYWOPWKMZEF<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private QueueItem <req>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x50097B0", Offset = "0x5007DB0", VA = "0x1850097B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x500AEB0", Offset = "0x50094B0", VA = "0x18500AEB0", Slot = "5")]
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
			public IYWOPWKMZEF<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x54D3EE0", Offset = "0x54D24E0", VA = "0x1854D3EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x54D49A0", Offset = "0x54D2FA0", VA = "0x1854D49A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CancellationTokenSource EBVFUKDBNSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly List<QueueItem> TODEEMKSULW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly IMGHHNHTBXY NYVJIKAWMSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly RequestProcessor CHFOLBPUQUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Task BXYATQKVQPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int WMHGVFMWEYJ;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x51E45E0", Offset = "0x51E2BE0", VA = "0x1851E45E0")]
		public IYWOPWKMZEF(RequestProcessor a, [Optional] IMGHHNHTBXY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x51E3550", Offset = "0x51E1B50", VA = "0x1851E3550")]
		public Task<b> ENBECHNDVGM(a a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x51E3840", Offset = "0x51E1E40", VA = "0x1851E3840")]
		private void GMWRHSCRAEB(QueueItem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x51E43A0", Offset = "0x51E29A0", VA = "0x1851E43A0")]
		[AsyncStateMachine(typeof(IYWOPWKMZEF<, >.<StartQueueProcess>d__12))]
		private Task ZDRVEZEGTJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x51E4020", Offset = "0x51E2620", VA = "0x1851E4020")]
		private QueueItem PRBAVHUSPTY()
		{
			return default(QueueItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x51E3B10", Offset = "0x51E2110", VA = "0x1851E3B10")]
		[AsyncStateMachine(typeof(IYWOPWKMZEF<, >.<DequeueItemAndRun>d__14))]
		private Task IFDRTEIDHBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x51E30F0", Offset = "0x51E16F0", VA = "0x1851E30F0")]
		private void BRLUUXPQAVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x51E31E0", Offset = "0x51E17E0", VA = "0x1851E31E0", Slot = "4")]
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
	public class MGSJIFXCFJF<a> : IList<a>, ICollection<a>, IEnumerable<a>, IEnumerable, IReadOnlyList<a>, IReadOnlyCollection<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly List<a> FCRPISOZHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HashSet<a> BZCQKDFTUCM;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB5D700", Offset = "0xB5BD00", VA = "0x180B5D700", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5948D70", Offset = "0x5947370", VA = "0x185948D70", Slot = "18")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5949140", Offset = "0x5947740", VA = "0x185949140", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5947AB0", Offset = "0x59460B0", VA = "0x185947AB0", Slot = "11")]
		public void Add(a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5948AF0", Offset = "0x59470F0", VA = "0x185948AF0")]
		public bool XTAYUFNCEYI(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x59486D0", Offset = "0x5946CD0", VA = "0x1859486D0", Slot = "15")]
		public bool Remove(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5947F30", Offset = "0x5946530", VA = "0x185947F30", Slot = "16")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x59483D0", Offset = "0x59469D0", VA = "0x1859483D0", Slot = "17")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5947C60", Offset = "0x5946260", VA = "0x185947C60", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5947D00", Offset = "0x5946300", VA = "0x185947D00", Slot = "13")]
		public bool Contains(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5947E20", Offset = "0x5946420", VA = "0x185947E20", Slot = "14")]
		public void CopyTo(a[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5948080", Offset = "0x5946680", VA = "0x185948080", Slot = "6")]
		public int IndexOf(a item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x59480B0", Offset = "0x59466B0", VA = "0x1859480B0", Slot = "7")]
		public void Insert(int index, a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5948620", Offset = "0x5946C20", VA = "0x185948620", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5948CA0", Offset = "0x59472A0", VA = "0x185948CA0")]
		public MGSJIFXCFJF()
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
		private Guid CIUTQQSTXBM;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2D9DFC0", Offset = "0x2D9C5C0", VA = "0x182D9DFC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84C9CB0", Offset = "0x84C82B0", VA = "0x1884C9CB0")]
		public SerializedGuid([In] Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84C9C40", Offset = "0x84C8240", VA = "0x1884C9C40")]
		public static SerializedGuid XTCJPTIRROT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84C9BD0", Offset = "0x84C81D0", VA = "0x1884C9BD0")]
		public static SerializedGuid RXYVTSBHJAT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84C9AC0", Offset = "0x84C80C0", VA = "0x1884C9AC0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x84C9BA0", Offset = "0x84C81A0", VA = "0x1884C9BA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84C9B20", Offset = "0x84C8120", VA = "0x1884C9B20", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84C99E0", Offset = "0x84C7FE0", VA = "0x1884C99E0", Slot = "7")]
		public bool Equals(SerializedGuid other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84C9A20", Offset = "0x84C8020", VA = "0x1884C9A20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x84C9AB0", Offset = "0x84C80B0", VA = "0x1884C9AB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84C99B0", Offset = "0x84C7FB0", VA = "0x1884C99B0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x84C9940", Offset = "0x84C7F40", VA = "0x1884C9940")]
		public SerializedGuidSourceAttribute(Type valueRetrieveMethodType, string valueRetrieveMethod, bool insertEmptyChoice = false, bool disabled = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface PEZVRBFFKOH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		int OWQVBORTAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<a> TXVMMJZUBJZ(float a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IBSQOOJURCB(float a, a b);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class YSLFQJKNQCS<a> : PEZVRBFFKOH<a>
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
			[Cpp2IlInjected.Address(RVA = "0x1099700", Offset = "0x1097D00", VA = "0x181099700")]
			public Sample(a value, float time)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class FKXZPHMCXEN : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private a MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public YSLFQJKNQCS<a> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private float RKBUCJXUHFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float GIBFRTIOTWE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float? ERJIKNZSSPX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float? HAJXETLCLLU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int GIVKULCPOUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int HAUFAUAXPHX;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private a HNCVYZVQHWH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xF383E0", Offset = "0xF369E0", VA = "0x180F383E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x4F33570", Offset = "0x4F31B70", VA = "0x184F33570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x15FB710", Offset = "0x15F9D10", VA = "0x1815FB710")]
			[DebuggerHidden]
			public FKXZPHMCXEN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4F33C40", Offset = "0x4F32240", VA = "0x184F33C40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x4F331C0", Offset = "0x4F317C0", VA = "0x184F331C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CDFQCYMHDZO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x4F33650", Offset = "0x4F31C50", VA = "0x184F33650", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly float XUSSZNTCPNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly float EIMSCZVDCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly List<Sample> AAHTEGEPSOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int KNAVBOLYRXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int CHPPPODJEHT;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int OWQVBORTAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x40AFB30", Offset = "0x40AE130", VA = "0x1840AFB30")]
		public YSLFQJKNQCS(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x40AF220", Offset = "0x40AD820", VA = "0x1840AF220", Slot = "6")]
		public bool IBSQOOJURCB(float a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x40AEE50", Offset = "0x40AD450", VA = "0x1840AEE50", Slot = "8")]
		public int FICPZSKSGCP(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x40AF8B0", Offset = "0x40ADEB0", VA = "0x1840AF8B0", Slot = "5")]
		[IteratorStateMachine(typeof(YSLFQJKNQCS<>.FKXZPHMCXEN))]
		public IEnumerable<a> TXVMMJZUBJZ(float a, float? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x40AEDF0", Offset = "0x40AD3F0", VA = "0x1840AEDF0", Slot = "7")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x40AF570", Offset = "0x40ADB70", VA = "0x1840AF570")]
		private void NRLAVZLBVNU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x40AF410", Offset = "0x40ADA10", VA = "0x1840AF410")]
		private Sample IQSIZUAYDDE()
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
			[Cpp2IlInjected.Address(RVA = "0x6318080", Offset = "0x6316680", VA = "0x186318080")]
			public TimerEntry(long startTicks, int startFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6318050", Offset = "0x6316650", VA = "0x186318050")]
			public TimerEntry(long startTicks, long endTicks, int startFrame, int endFrame, bool isDone, string stackTrace)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6317EB0", Offset = "0x63164B0", VA = "0x186317EB0")]
			public int LMCPCKRMDYE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6317F80", Offset = "0x6316580", VA = "0x186317F80")]
			public int XVCSRBXYMPK(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6317DF0", Offset = "0x63163F0", VA = "0x186317DF0")]
			public double KHIGSNHTEWC()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6317D50", Offset = "0x6316350", VA = "0x186317D50")]
			public TimerEntry IWHBMSWDBPV(long a, int b)
			{
				return default(TimerEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class ERYHZSBUWXZ : IDisposable
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
				public ERYHZSBUWXZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public TKey key;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				public Func<ERYHZSBUWXZ, Task<T>> function;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				private ERYHZSBUWXZ <internalTimer>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				private TaskAwaiter<T> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x55772E0", Offset = "0x55758E0", VA = "0x1855772E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x50224D0", Offset = "0x5020AD0", VA = "0x1850224D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public readonly TKey SSZWFWYFAPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private readonly StackTimer<TKey> TYIPCZXJUDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public readonly Log WOAZIZZDVRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private List<ERYHZSBUWXZ> IJIJALFOLRF;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public string VVCSRXOTRRP
			{
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x49367B0", Offset = "0x4934DB0", VA = "0x1849367B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public IEnumerable<ERYHZSBUWXZ> RMEPSDQKBPN
			{
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x49368F0", Offset = "0x4934EF0", VA = "0x1849368F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public TimerEntry VHVIDDFWTCH
			{
				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x236FDA0", Offset = "0x236E3A0", VA = "0x18236FDA0")]
				[CompilerGenerated]
				get
				{
					return default(TimerEntry);
				}
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x4936840", Offset = "0x4934E40", VA = "0x184936840")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x49369E0", Offset = "0x4934FE0", VA = "0x1849369E0")]
			internal ERYHZSBUWXZ(StackTimer<TKey> a, TKey b, Log c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x49361E0", Offset = "0x49347E0", VA = "0x1849361E0")]
			public ERYHZSBUWXZ NTVZETMVIKJ(TKey a, [Optional] Log? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x38FC910", Offset = "0x38FAF10", VA = "0x1838FC910")]
			[AsyncStateMachine(typeof(<WrapAsync>d__17<>))]
			public Task<b> TFQYHSHXVWI<b>(TKey a, Func<ERYHZSBUWXZ, Task<b>> b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4935DC0", Offset = "0x49343C0", VA = "0x184935DC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class YXVSYLVWHCH : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public StackTimer<TKey> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> TPFONUYPLCA;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private (TKey, List<TKey>, TimerEntry) KJJYDZIWTXM
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x2D82D80", Offset = "0x2D81380", VA = "0x182D82D80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x40B8C60", Offset = "0x40B7260", VA = "0x1840B8C60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2D836D0", Offset = "0x2D81CD0", VA = "0x182D836D0")]
			[DebuggerHidden]
			public YXVSYLVWHCH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x40B8A60", Offset = "0x40B7060", VA = "0x1840B8A60", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x40B8EC0", Offset = "0x40B74C0", VA = "0x1840B8EC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x40B8D90", Offset = "0x40B7390", VA = "0x1840B8D90")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x40B9910", Offset = "0x40B7F10", VA = "0x1840B9910", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> WLJYNXAWRYB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x40B8E00", Offset = "0x40B7400", VA = "0x1840B8E00", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class YXQMBFBYXQY : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private List<TKey> JCDBSKRWXIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public List<TKey> AZEPAYANFAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private ERYHZSBUWXZ VSKWOZOOEPR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public ERYHZSBUWXZ NFZKYAUYXQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public StackTimer<TKey> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private IEnumerator<ERYHZSBUWXZ> TPFONUYPLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> TPVJFPGHNKB;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			private (TKey, List<TKey>, TimerEntry) KJJYDZIWTXM
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2D82D80", Offset = "0x2D81380", VA = "0x182D82D80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0x40B6D80", Offset = "0x40B5380", VA = "0x1840B6D80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2D836D0", Offset = "0x2D81CD0", VA = "0x182D836D0")]
			[DebuggerHidden]
			public YXQMBFBYXQY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x40B6BF0", Offset = "0x40B51F0", VA = "0x1840B6BF0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x40B7ED0", Offset = "0x40B64D0", VA = "0x1840B7ED0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x40B6F10", Offset = "0x40B5510", VA = "0x1840B6F10")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x40B6DD0", Offset = "0x40B53D0", VA = "0x1840B6DD0")]
			private void KOSXCWUKUNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x40B88D0", Offset = "0x40B6ED0", VA = "0x1840B88D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> WLJYNXAWRYB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x40B7080", Offset = "0x40B5680", VA = "0x1840B7080", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Action<TKey, TimerEntry, Log> UPVPBJMPKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Action<TKey, TimerEntry, Log> SLPEUXLTCBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Action<StackTimer<TKey>, Log> MATAQOUYMNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly ERYHZSBUWXZ XJDQJKSDYIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool ADKFKWBUFYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int NWEVQPKIOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Stopwatch RBVGTTLJPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly int VFEMERADTQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private string MKVRXURAGRS;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public ERYHZSBUWXZ UVSXTRRITIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		[NotNull]
		public string VVCSRXOTRRP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x6105640", Offset = "0x6103C40", VA = "0x186105640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6105950", Offset = "0x6103F50", VA = "0x186105950")]
		public StackTimer(TKey rootKey, Log log, [Optional] int? startFrame, [Optional][CanBeNull] Stopwatch stopwatch, [Optional] Action<TKey, TimerEntry, Log> pushCallback, [Optional] Action<TKey, TimerEntry, Log> popCallback, [Optional] Action<StackTimer<TKey>, Log> disposeCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6105080", Offset = "0x6103680", VA = "0x186105080", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6105440", Offset = "0x6103A40", VA = "0x186105440")]
		[IteratorStateMachine(typeof(StackTimer<>.YXVSYLVWHCH))]
		public IEnumerable<(TKey, List<TKey>, TimerEntry)> QGIVCEDNFKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6105380", Offset = "0x6103980", VA = "0x186105380")]
		[IteratorStateMachine(typeof(StackTimer<>.YXQMBFBYXQY))]
		private IEnumerable<(TKey, List<TKey>, TimerEntry)> QGIVCEDNFKF(List<TKey> a, ERYHZSBUWXZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61051C0", Offset = "0x61037C0", VA = "0x1861051C0")]
		private (long, int) Now()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class GLUJJOPAACH<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b Format(StackTimer<a> timer);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected GLUJJOPAACH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class MCOKPROFBIA<a> : GLUJJOPAACH<a, string>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5947130", Offset = "0x5945730", VA = "0x185947130")]
		private static string UHWDZYNNPWI(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5946C20", Offset = "0x5945220", VA = "0x185946C20", Slot = "4")]
		public override string Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5946F30", Offset = "0x5945530", VA = "0x185946F30")]
		public string Format(StackTimer<a> timer, [NotNull] KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract string AILCJXJUYCW(StackTimer<a> a, [NotNull] KeyToStringFunc keyToStringFunc);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5947170", Offset = "0x5945770", VA = "0x185947170")]
		protected MCOKPROFBIA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class ESLDQJSWQQK<a> : GLUJJOPAACH<a, Dictionary<string, string>>
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string WKBLOJFUTKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly double TJFIUJYVLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly bool BZOOSSWUPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly int VHLGZFHXUBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ISet<string> SMHBWAIFSCH;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4939D30", Offset = "0x4938330", VA = "0x184939D30")]
		private static string UHWDZYNNPWI(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x493A2D0", Offset = "0x49388D0", VA = "0x18493A2D0")]
		public ESLDQJSWQQK(string a = "F2", double b = 1.7976931348623157E+308, bool c = false, int d = 2147483647, [Optional] ISet<string> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4938B40", Offset = "0x4937140", VA = "0x184938B40", Slot = "4")]
		public override Dictionary<string, string> Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4939CC0", Offset = "0x49382C0", VA = "0x184939CC0")]
		private bool LHBQNQRVPEM(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4939300", Offset = "0x4937900", VA = "0x184939300")]
		public Dictionary<string, string> Format(StackTimer<a> timer, KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x493A190", Offset = "0x4938790", VA = "0x18493A190")]
		private string WREJEJFDLWX(StringBuilder a, List<a> b, KeyToStringFunc c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4939B00", Offset = "0x4938100", VA = "0x184939B00")]
		private static void GTJESSDWEQZ(StringBuilder a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class WCNFDWXWGZD<a> : MCOKPROFBIA<a>
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
		public static WCNFDWXWGZD<a> ZQTZABWNUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly string[] JHNSVGPXQGA;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x68594A0", Offset = "0x6857AA0", VA = "0x1868594A0")]
		private WCNFDWXWGZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6857570", Offset = "0x6855B70", VA = "0x186857570", Slot = "5")]
		protected override string AILCJXJUYCW(StackTimer<a> a, KeyToStringFunc b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x68590F0", Offset = "0x68576F0", VA = "0x1868590F0")]
		[CompilerGenerated]
		internal static string AXWEAQTJUOK(string a, a b, <>c__DisplayClass4_0 c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class UZCBXMWOQTS : StackTimer<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class MVZLYDKGBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public Action<UZCBXMWOQTS, Log> CXPPTSBKHFV;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MVZLYDKGBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x84C81B0", Offset = "0x84C67B0", VA = "0x1884C81B0")]
			internal void UOQBNTCYQDE(StackTimer<string> a, Log b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x84CB1E0", Offset = "0x84C97E0", VA = "0x1884CB1E0")]
		public UZCBXMWOQTS(Log a, [Optional] string b, [Optional] int? c, [Optional] Stopwatch d, [Optional] Action<string, TimerEntry, Log> e, [Optional] Action<string, TimerEntry, Log> f, [Optional] Action<UZCBXMWOQTS, Log> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84CB120", Offset = "0x84C9720", VA = "0x1884CB120")]
		private static Action<StackTimer<string>, Log> VFWPIDTNKJS(Action<UZCBXMWOQTS, Log> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class KNGIEQABMTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private class ROWGKDYMOSF : KNGIEQABMTC
		{
			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static KNGIEQABMTC ZQTZABWNUIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x84C8430", Offset = "0x84C6A30", VA = "0x1884C8430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override float PEDIUXVUTYW
			{
				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0x1453010", Offset = "0x1451610", VA = "0x181453010", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x84C8520", Offset = "0x84C6B20", VA = "0x1884C8520")]
			public ROWGKDYMOSF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static KNGIEQABMTC RFTZJVEPMZV;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static KNGIEQABMTC AMLVLGFTEOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x84C7F00", Offset = "0x84C6500", VA = "0x1884C7F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract float PEDIUXVUTYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected KNGIEQABMTC()
		{
		}
	}
}
namespace RecRoom.DataStructures.ResourceHandles
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface LZYDFBYDTQN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool SHXMMQDRCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface XJCVXUISJRI<a> : LZYDFBYDTQN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[NotNull]
		Task<a> ICUGQWPTWJP
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[NotNull]
		NDLOPTUCVYP<a> DIYAHISPKKR
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class YQKXBDQPRLZ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8270", Offset = "0x3EE6870", VA = "0x183EE8270")]
		public static XJCVXUISJRI<TResource> IJBTBRLDPRM<TResource, a>(this NCYAISNNWQN<a, TResource> a, a b, [Optional] Func<a, CancellationToken, Task<TResource>>? resourceFactory) where TResource : notnull where a : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class DSZHPUWDPVM
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class KMCHIVGDFRG<a> : CDPKZCVFWHO<a?> where a : class
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override Task<a?> ICUGQWPTWJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override NDLOPTUCVYP<a?> DIYAHISPKKR
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x53B0F80", Offset = "0x53AF580", VA = "0x1853B0F80")]
			public KMCHIVGDFRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "10")]
			protected override void AJNZZLQWPYW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class WWUBDSVHFXC<a> : CDPKZCVFWHO<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private readonly a XFTOBCUCUTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private readonly Action<a>? HFLKEGLEGGN;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public override Task<a> ICUGQWPTWJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override NDLOPTUCVYP<a> DIYAHISPKKR
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x6869E70", Offset = "0x6868470", VA = "0x186869E70")]
			public WWUBDSVHFXC(a a, Action<a>? onDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x6869E30", Offset = "0x6868430", VA = "0x186869E30", Slot = "10")]
			protected override void AJNZZLQWPYW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class BVVOFTPHELW<a> : CDPKZCVFWHO<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override Task<a> ICUGQWPTWJP
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NDLOPTUCVYP<a> DIYAHISPKKR
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x7212AA0", Offset = "0x72110A0", VA = "0x187212AA0")]
			public BVVOFTPHELW(Exception a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "10")]
			protected override void AJNZZLQWPYW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class IVOXXBQWMAA<a> : CDPKZCVFWHO<a> where a : notnull
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
				public Task<XJCVXUISJRI<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				private TaskAwaiter<XJCVXUISJRI<a>> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				private TaskAwaiter<a> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x3F938A0", Offset = "0x3F91EA0", VA = "0x183F938A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x3F93D40", Offset = "0x3F92340", VA = "0x183F93D40", Slot = "5")]
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
				public Task<XJCVXUISJRI<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				private TaskAwaiter<XJCVXUISJRI<a>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3F96700", Offset = "0x3F94D00", VA = "0x183F96700", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x3F96DA0", Offset = "0x3F953A0", VA = "0x183F96DA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private readonly Task<XJCVXUISJRI<a>> CUSNWYRCZFW;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override Task<a> ICUGQWPTWJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override NDLOPTUCVYP<a> DIYAHISPKKR
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x51E22A0", Offset = "0x51E08A0", VA = "0x1851E22A0")]
			public IVOXXBQWMAA(Task<XJCVXUISJRI<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x51E15E0", Offset = "0x51DFBE0", VA = "0x1851E15E0", Slot = "10")]
			protected override void AJNZZLQWPYW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x51E1D50", Offset = "0x51E0350", VA = "0x1851E1D50")]
			[AsyncStateMachine(typeof(IVOXXBQWMAA<>.<<-ctor>g__Unwrap|7_0>d))]
			[CompilerGenerated]
			internal static Task<a> LCIVHPFLSNC(Task<XJCVXUISJRI<a>> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x51E19D0", Offset = "0x51DFFD0", VA = "0x1851E19D0")]
			[AsyncStateMachine(typeof(IVOXXBQWMAA<>.<<OnDispose>g__AwaitThenDispose|8_0>d))]
			[CompilerGenerated]
			internal static Task FLGIVSIDJMG(Task<XJCVXUISJRI<a>> a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private sealed class URWRUGFXXWY<a, b> : CDPKZCVFWHO<b> where a : notnull where b : notnull
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
				[Cpp2IlInjected.Address(RVA = "0x3F92320", Offset = "0x3F90920", VA = "0x183F92320", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x3F92CB0", Offset = "0x3F912B0", VA = "0x183F92CB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly XJCVXUISJRI<a> ZPMBASQFQYB;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override Task<b> ICUGQWPTWJP
			{
				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override NDLOPTUCVYP<b> DIYAHISPKKR
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0570", Offset = "0x63BEB70", VA = "0x1863C0570")]
			public URWRUGFXXWY(XJCVXUISJRI<a> a, Func<a, b> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x63C0050", Offset = "0x63BE650", VA = "0x1863C0050", Slot = "10")]
			protected override void AJNZZLQWPYW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x63C00A0", Offset = "0x63BE6A0", VA = "0x1863C00A0")]
			[AsyncStateMachine(typeof(URWRUGFXXWY<, >.<<-ctor>g__Transform|7_0>d))]
			[CompilerGenerated]
			internal static Task<b> JRQSBMPAFHP(Task<a> a, Func<a, b> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x37ACC90", Offset = "0x37AB290", VA = "0x1837ACC90")]
		public static XJCVXUISJRI<T> Empty<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x37ACBF0", Offset = "0x37AB1F0", VA = "0x1837ACBF0")]
		public static XJCVXUISJRI<T> DMEHPVFZCJX<T>(T a, [Optional] Action<T>? onDispose) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x37ACA80", Offset = "0x37AB080", VA = "0x1837ACA80")]
		public static XJCVXUISJRI<T> CSVJVKCCUUR<T>(Exception a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x37ACCF0", Offset = "0x37AB2F0", VA = "0x1837ACCF0")]
		public static XJCVXUISJRI<T> JIKAPZNOWKB<T>(Task<XJCVXUISJRI<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x37ACE50", Offset = "0x37AB450", VA = "0x1837ACE50")]
		public static XJCVXUISJRI<TOut> Transform<TOut, TIn>(XJCVXUISJRI<TIn> handle, Func<TIn, TOut> transformFunc) where TOut : notnull where TIn : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public abstract class CDPKZCVFWHO<a> : XJCVXUISJRI<a>, LZYDFBYDTQN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static readonly string JSTBWYPMVHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DisposeReminder NKCGMIYPAYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private bool ADKFKWBUFYD;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool SHXMMQDRCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xBE49E0", Offset = "0xBE2FE0", VA = "0x180BE49E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract Task<a> ICUGQWPTWJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public abstract NDLOPTUCVYP<a> DIYAHISPKKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x40242C0", Offset = "0x40228C0", VA = "0x1840242C0")]
		public CDPKZCVFWHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4023F80", Offset = "0x4022580", VA = "0x184023F80", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void AJNZZLQWPYW();
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class CEFFQXCXYPP<a, b> : CDPKZCVFWHO<b> where a : Task
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class OGOKSBBDBET
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
				public OGOKSBBDBET <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x3F91B30", Offset = "0x3F90130", VA = "0x183F91B30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3F921D0", Offset = "0x3F907D0", VA = "0x183F921D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public CEFFQXCXYPP<a, b> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public CancellationToken LRZKPIGDYNN;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGOKSBBDBET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x5BBF7B0", Offset = "0x5BBDDB0", VA = "0x185BBF7B0")]
			[AsyncStateMachine(typeof(CEFFQXCXYPP<, >.OGOKSBBDBET.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
			internal Task<b> JDDJXWDUODA(a a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Task<b> NFTCNHNNPYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		protected readonly CancellationTokenSource ERMOUZTPHRP;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override Task<b> ICUGQWPTWJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override NDLOPTUCVYP<b> DIYAHISPKKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4024560", Offset = "0x4022B60", VA = "0x184024560")]
		protected CEFFQXCXYPP(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4024360", Offset = "0x4022960", VA = "0x184024360", Slot = "10")]
		protected override void AJNZZLQWPYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract b FLDKSYAVWQA(a a);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void JPYJZULPVVX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class GNBADHQNDUK<a> : CDPKZCVFWHO<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly VKOWOQQTYXQ<Task<a>> KBLOKRTWLGK;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override Task<a> ICUGQWPTWJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xFDE8C0", Offset = "0xFDCEC0", VA = "0x180FDE8C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override NDLOPTUCVYP<a> DIYAHISPKKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x506E9B0", Offset = "0x506CFB0", VA = "0x18506E9B0")]
		public GNBADHQNDUK(VKOWOQQTYXQ<Task<a>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x506E940", Offset = "0x506CF40", VA = "0x18506E940", Slot = "10")]
		protected override void AJNZZLQWPYW()
		{
		}
	}
}
namespace RecRoom.DataStructures.Hashing
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class UITREEPHNDQ
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly HashAlgorithmName EJCUIGUWHDU;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly ThreadLocal<IncrementalHash> AGIHXYIKKXV;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x84CAF60", Offset = "0x84C9560", VA = "0x1884CAF60")]
		public static int VKUMNWCJBMD(this ILEAYNPSJIV a, IncrementalHash b, byte[] c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x84CAE70", Offset = "0x84C9470", VA = "0x1884CAE70")]
		public static bool FXREGZSRLDA([CanBeNull] this ILEAYNPSJIV hashableAsset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84CA860", Offset = "0x84C8E60", VA = "0x1884CA860")]
		public static bool FXREGZSRLDA([CanBeNull] this ILEAYNPSJIV hashableAsset, [Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x84CAB60", Offset = "0x84C9160", VA = "0x1884CAB60")]
		public static bool FXREGZSRLDA([CanBeNull] this ILEAYNPSJIV hashableAsset, IncrementalHash a, byte[] b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x84CAED0", Offset = "0x84C94D0", VA = "0x1884CAED0")]
		private static bool JOUEKFFQUQU(byte[] a, Span<byte> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class KPSXOIBOKNQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x84C8060", Offset = "0x84C6660", VA = "0x1884C8060")]
		public static int CDMUJTJNLBP(HashAlgorithmName a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39B8860", Offset = "0x39B6E60", VA = "0x1839B8860")]
		public static int VKUMNWCJBMD<a>(this a a, byte[] b, IncrementalHash c, byte[] d) where a : SNNCNTNADPN
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface SNNCNTNADPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AppendToHash([NotNull] IncrementalHash hash);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface ILEAYNPSJIV : SNNCNTNADPN
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[CanBeNull]
		byte[] FKCFSQMJZGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[CanBeNull]
		byte[] CJWBONVVFMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class WYKWETTXTFE
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static bool DPUMSGKHZVK;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly ArrayPool<byte> MCKHLJJIMQD;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly ArrayPool<char> MDBHPJDTHVZ;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly Encoding IEYKRSCDZIC;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ThreadLocal<Encoder> UWLOJTAFSIF;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9520", Offset = "0x3EC7B20", VA = "0x183EC9520")]
		public static void STUUTBBFHQO<b>(this IncrementalHash a, [CanBeNull] b component) where b : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3EC93D0", Offset = "0x3EC79D0", VA = "0x183EC93D0")]
		public static void FWDHWGHMPYM<c>(this IncrementalHash a, [CanBeNull] c hashable) where c : SNNCNTNADPN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9980", Offset = "0x3EC7F80", VA = "0x183EC9980")]
		public static void WVLNAGZMQQR<d>(this IncrementalHash a, [CanBeNull] IList<d> hashablesList) where d : SNNCNTNADPN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84CC290", Offset = "0x84CA890", VA = "0x1884CC290")]
		private static bool SYWSYJTRENF([CanBeNull] SNNCNTNADPN hashable)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x84CBD80", Offset = "0x84CA380", VA = "0x1884CBD80")]
		public static void OUWTOCVNLAV(this IncrementalHash a, string? stringValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x84CB640", Offset = "0x84C9C40", VA = "0x1884CB640")]
		public static void ACXYQOZXPQK(this IncrementalHash a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x84CB9E0", Offset = "0x84C9FE0", VA = "0x1884CB9E0")]
		public static void IDBBCTNSPSR(this IncrementalHash a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x84CBB50", Offset = "0x84CA150", VA = "0x1884CBB50")]
		public static void LAUEKYDZERA(this IncrementalHash a, short b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x84CC320", Offset = "0x84CA920", VA = "0x1884CC320")]
		public static void WVVOEDKATYO(this IncrementalHash a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x84CB7B0", Offset = "0x84C9DB0", VA = "0x1884CB7B0")]
		public static void AGKEKOXDPUN(this IncrementalHash a, bool b, bool c = false, bool d = false, bool e = false, bool f = false, bool g = false, bool h = false, bool i = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3EC81F0", Offset = "0x3EC67F0", VA = "0x183EC81F0")]
		public static void BFKOVDIVBMJ<e>(this IncrementalHash a, e b) where e : struct, Enum, IConvertible
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x84CBCC0", Offset = "0x84CA2C0", VA = "0x1884CBCC0")]
		public static void MDVELAWODRU(this IncrementalHash a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x84CB920", Offset = "0x84C9F20", VA = "0x1884CB920")]
		public static void BSPNOKFOWVP(this IncrementalHash a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x84CBD20", Offset = "0x84CA320", VA = "0x1884CBD20")]
		public static void OMJVRDUOGWM(this IncrementalHash a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x84CB980", Offset = "0x84C9F80", VA = "0x1884CB980")]
		public static void CFCFMWBSLMT(this IncrementalHash a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x84CC160", Offset = "0x84CA760", VA = "0x1884CC160")]
		public static void PQMXOTUEPLK(this IncrementalHash a, Vector3 b)
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
		[Cpp2IlInjected.Address(RVA = "0x84C7B60", Offset = "0x84C6160", VA = "0x1884C7B60")]
		public DataDesyncException(string message)
		{
		}
	}
}
namespace RecRoom.Core.Scripts.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class TKODIRJNIIY
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate void OnStateChange(ushort currentStateId, ushort previousStateId, ushort currentSubStateId, ushort previousSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate void StateTransition(ushort otherStateId, ushort otherSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public delegate void StateUpdate();

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public const ushort QFHTZQAWARF = 65535;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected TKODIRJNIIY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class EFRSAMRBGZJ<a> : TKODIRJNIIY where a : EFRSAMRBGZJ<a>.HSDDUGDLDIA
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public interface HSDDUGDLDIA
		{
			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			StateTransition CNBUKJQBUON
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			StateTransition YRLYJMOURFL
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			StateUpdate YMZPHPXKHAU
			{
				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<uint, a> JNJGLXXPKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private StateUpdate CYJQANWMJYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private StateUpdate RETTYFKDZTH;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool EPXGPBVWKZW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB3D10", Offset = "0xAB2310", VA = "0x180AB3D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ushort GYMUTCMTSRZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x12F1320", Offset = "0x12EF920", VA = "0x1812F1320")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x12F0E60", Offset = "0x12EF460", VA = "0x1812F0E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public ushort EJVKNCFDYFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4927F30", Offset = "0x4926530", VA = "0x184927F30")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4927F50", Offset = "0x4926550", VA = "0x184927F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ushort CLFMOOKPSDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xFCA590", Offset = "0xFC8B90", VA = "0x180FCA590")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xFCA650", Offset = "0xFC8C50", VA = "0x180FCA650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ushort OCVLCSGFIQL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x49281E0", Offset = "0x49267E0", VA = "0x1849281E0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x49286A0", Offset = "0x4926CA0", VA = "0x1849286A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected bool XIFOJCWPKFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x12F1310", Offset = "0x12EF910", VA = "0x1812F1310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected bool YFPKCYDSYDL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xCB9800", Offset = "0xCB7E00", VA = "0x180CB9800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OnStateChange XHBVSAHLWNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4928000", Offset = "0x4926600", VA = "0x184928000")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4928750", Offset = "0x4926D50", VA = "0x184928750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4926BE0", Offset = "0x49251E0", VA = "0x184926BE0")]
		private a AJRVKBJLLOY(ushort a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x49281F0", Offset = "0x49267F0", VA = "0x1849281F0")]
		private a NHCQFGAEEKX(ushort a, ushort b)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4928550", Offset = "0x4926B50", VA = "0x184928550")]
		protected a QWFKZIXXEHF(uint a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4928E20", Offset = "0x4927420", VA = "0x184928E20")]
		protected EFRSAMRBGZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x49283D0", Offset = "0x49269D0", VA = "0x1849283D0")]
		public void QNNSLYOVUYL(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x49283B0", Offset = "0x49269B0", VA = "0x1849283B0")]
		public void QNNSLYOVUYL(ushort a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4928440", Offset = "0x4926A40", VA = "0x184928440", Slot = "4")]
		protected virtual void QNNSLYOVUYL(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4926D90", Offset = "0x4925390", VA = "0x184926D90")]
		protected void DWMRNBVVUIN(uint a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x49287F0", Offset = "0x4926DF0", VA = "0x1849287F0")]
		protected void ZHNBTVKSTSV(ushort a, ushort b, a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x49280A0", Offset = "0x49266A0", VA = "0x1849280A0")]
		private void JXQKJVSWUJV(uint a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4928980", Offset = "0x4926F80", VA = "0x184928980")]
		protected void ZORFAOVDMNZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4927F40", Offset = "0x4926540", VA = "0x184927F40")]
		protected uint FOKHTXLDRDE(ushort a, ushort b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4927F20", Offset = "0x4926520", VA = "0x184927F20")]
		protected ushort DZDONWOUNXE(uint a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4926D80", Offset = "0x4925380", VA = "0x184926D80")]
		protected ushort DRPJFHGHOGF(uint a)
		{
			return default(ushort);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class GKBLUEUQUHZ : EFRSAMRBGZJ<GKBLUEUQUHZ.State>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class State : HSDDUGDLDIA
		{
			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public StateTransition CNBUKJQBUON
			{
				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public StateTransition YRLYJMOURFL
			{
				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public StateUpdate YMZPHPXKHAU
			{
				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x84C7CB0", Offset = "0x84C62B0", VA = "0x1884C7CB0")]
		public void DXPCHBKZYFS(ushort a, StateTransition b, StateTransition c, StateUpdate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x84C7D90", Offset = "0x84C6390", VA = "0x1884C7D90")]
		public void DXPCHBKZYFS(ushort a, ushort b, StateTransition c, StateTransition d, StateUpdate e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x84C7E70", Offset = "0x84C6470", VA = "0x1884C7E70")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x84C7EC0", Offset = "0x84C64C0", VA = "0x1884C7EC0")]
		protected GKBLUEUQUHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class XVUJPURJBMB : GKBLUEUQUHZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool CKEQEOVBORT;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xFD3F90", Offset = "0xFD2590", VA = "0x180FD3F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xFD3B30", Offset = "0xFD2130", VA = "0x180FD3B30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x84CC6A0", Offset = "0x84CACA0", VA = "0x1884CC6A0")]
		public void Initialize(ushort initialStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x84CC700", Offset = "0x84CAD00", VA = "0x1884CC700")]
		public void Initialize(ushort initialStateId, ushort initialSubStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x84C7EC0", Offset = "0x84C64C0", VA = "0x1884C7EC0")]
		public XVUJPURJBMB()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class LKKIGZASLHY<a, b> : IDisposable where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal class WIATZMFHOME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public b ECYRSYGSVOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public b SEJYAKTRJIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public PriorityClaim ZLCVZYTXLXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public List<PriorityClaim> PBTQEBOPMIO;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public WIATZMFHOME()
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
			[Cpp2IlInjected.Address(RVA = "0x19C4AC0", Offset = "0x19C30C0", VA = "0x1819C4AC0")]
			public PriorityClaim(int priority, a claim)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x5CC3B60", Offset = "0x5CC2160", VA = "0x185CC3B60")]
			public bool CDGAOKUNSNT([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x5CC3BD0", Offset = "0x5CC21D0", VA = "0x185CC3BD0")]
			public bool KDJUPBPKQFS([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x5CC3BC0", Offset = "0x5CC21C0", VA = "0x185CC3BC0", Slot = "4")]
			public int CompareTo(PriorityClaim other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x5CC3BE0", Offset = "0x5CC21E0", VA = "0x185CC3BE0", Slot = "3")]
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
		private sealed class MNXUTXXMKMM : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private b MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private b LNTJNGFDHMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public b VEGJYBWNDRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public LKKIGZASLHY<a, b> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private b DHQNZOJGROB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public b HHNROALKFQE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private bool PFBFTTRSSWB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public bool GBMLFRHXQHI;

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			private b RCXJOIDERHJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public MNXUTXXMKMM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x59D5150", Offset = "0x59D3750", VA = "0x1859D5150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x59D5230", Offset = "0x59D3830", VA = "0x1859D5230", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> XZMVNHYUKHS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x59D5070", Offset = "0x59D3670", VA = "0x1859D5070", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly JCXFKNWQUWH<WIATZMFHOME> TAJVBCOLPHY;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly JCXFKNWQUWH<List<PriorityClaim>> PKMYGDAXLBU;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static int SDMUENMLWWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		internal readonly Dictionary<a, b> JRYGPJBSUFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		internal readonly Dictionary<b, WIATZMFHOME> RDFRRVUSQPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mode JXELZYALEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool MFRVCTFDCZV;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract b TXGKFWFDMWI(b a);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void EILQCLTPMDK(b a, a b, a c);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x547DE70", Offset = "0x547C470", VA = "0x18547DE70")]
		public LKKIGZASLHY(Mode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x547C410", Offset = "0x547AA10", VA = "0x18547C410")]
		public void BKNKBPGMVOR(b a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x547CE20", Offset = "0x547B420", VA = "0x18547CE20")]
		public void MUNIADLIZQJ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x547C490", Offset = "0x547AA90", VA = "0x18547C490", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x547C6F0", Offset = "0x547ACF0", VA = "0x18547C6F0")]
		private void IJWJBAWIWQG(a a, b b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x547D7A0", Offset = "0x547BDA0", VA = "0x18547D7A0")]
		private int WSPCPXKVCXI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x547D950", Offset = "0x547BF50", VA = "0x18547D950")]
		private void YSYMVQKFFQL(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x547D6B0", Offset = "0x547BCB0", VA = "0x18547D6B0")]
		private void VOUYMKPYMIA(PriorityClaim a, WIATZMFHOME b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x547C780", Offset = "0x547AD80", VA = "0x18547C780")]
		private void JAGLJXAGTHV(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x547D350", Offset = "0x547B950", VA = "0x18547D350")]
		private void VEEBSJOCKMA(PriorityClaim a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x547C630", Offset = "0x547AC30", VA = "0x18547C630")]
		private void IGZLXFTOKRK(PriorityClaim a, WIATZMFHOME b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x547D090", Offset = "0x547B690", VA = "0x18547D090")]
		private void NTSEVINJRAV(WIATZMFHOME a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x547CB20", Offset = "0x547B120", VA = "0x18547CB20")]
		private void LPIAZGEQAVX(WIATZMFHOME a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x547CA50", Offset = "0x547B050", VA = "0x18547CA50")]
		[IteratorStateMachine(typeof(LKKIGZASLHY<, >.MNXUTXXMKMM))]
		private IEnumerable<b> JCXUZMPTMTH(b a, b b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x547D1A0", Offset = "0x547B7A0", VA = "0x18547D1A0")]
		private WIATZMFHOME PITZRKXGOYJ(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x547CF60", Offset = "0x547B560", VA = "0x18547CF60")]
		private WIATZMFHOME NPFKMNXTTKY(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x547D800", Offset = "0x547BE00", VA = "0x18547D800")]
		private void YKOZTCRPUIG(WIATZMFHOME a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class AQJIXPNABGW<a> : IEnumerable<AQJIXPNABGW<a>.Pair>, IEnumerable
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
		public class DWOEAIOCRIO : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private AQJIXPNABGW<a> IJSTTSQZDUC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private int RQNIDISRYME;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x431E7D0", Offset = "0x431CDD0", VA = "0x18431E7D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x431EA20", Offset = "0x431D020", VA = "0x18431EA20", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x431E9E0", Offset = "0x431CFE0", VA = "0x18431E9E0")]
			public DWOEAIOCRIO(AQJIXPNABGW<a> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x431E820", Offset = "0x431CE20", VA = "0x18431E820", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x431E9D0", Offset = "0x431CFD0", VA = "0x18431E9D0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xFCB320", Offset = "0xFC9920", VA = "0x180FCB320", Slot = "5")]
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
		private const int YHDVLSXVNCS = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly Dictionary<a, int> CTDKVGWHAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ListEntry[] TCABNMKCGZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int MISFHQOLQAZ;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int SNAWMXTYBEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xACE970", Offset = "0xACCF70", VA = "0x180ACE970")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xF68720", Offset = "0xF66D20", VA = "0x180F68720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x4312AC0", Offset = "0x43110C0", VA = "0x184312AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x561AC20", Offset = "0x5619220", VA = "0x18561AC20")]
		public AQJIXPNABGW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x561A710", Offset = "0x5618D10", VA = "0x18561A710")]
		public AQJIXPNABGW(Pair[] a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5619080", Offset = "0x5617680", VA = "0x185619080")]
		public int RTAQZCXNWNJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5618740", Offset = "0x5616D40", VA = "0x185618740")]
		private int DYVRONBYXJG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5618A40", Offset = "0x5617040", VA = "0x185618A40", Slot = "6")]
		protected virtual uint HLLFKAATUGY(uint a, a b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5618EA0", Offset = "0x56174A0", VA = "0x185618EA0")]
		public bool RCFYMJCVLYK(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5618DC0", Offset = "0x56173C0", VA = "0x185618DC0")]
		public int MXWWWVJKWII(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5618A60", Offset = "0x5617060", VA = "0x185618A60")]
		public a MSUQGLLKEHH(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x56190B0", Offset = "0x56176B0", VA = "0x1856190B0")]
		public bool XTAYUFNCEYI(a a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x56190F0", Offset = "0x56176F0", VA = "0x1856190F0")]
		public bool XTAYUFNCEYI(a a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5618060", Offset = "0x5616660", VA = "0x185618060")]
		private int ABEWDRGLUWR(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5618100", Offset = "0x5616700", VA = "0x185618100", Slot = "5")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5618100", Offset = "0x5616700", VA = "0x185618100", Slot = "4")]
		private IEnumerator<Pair> ANMWXNBGOML()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class JCXFKNWQUWH<a> : IDisposable where a : new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Stack<a> RHVRLNHJSKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<a> VLEWHQZMWMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly int HGVJRKKTUZT;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x52AA140", Offset = "0x52A8740", VA = "0x1852AA140")]
		public static JCXFKNWQUWH<a> SPYOGMXQUXF(int a = 0, int b = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x52AA920", Offset = "0x52A8F20", VA = "0x1852AA920")]
		public JCXFKNWQUWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x52AA950", Offset = "0x52A8F50", VA = "0x1852AA950")]
		public JCXFKNWQUWH(int a, int b = 2147483647, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x52A95D0", Offset = "0x52A7BD0", VA = "0x1852A95D0")]
		public a Acquire()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x52A9E70", Offset = "0x52A8470", VA = "0x1852A9E70")]
		public void Release(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x52AA6E0", Offset = "0x52A8CE0", VA = "0x1852AA6E0")]
		private void ZVDMHQWKFKW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x52A9D00", Offset = "0x52A8300", VA = "0x1852A9D00")]
		private void HHFBJWGQFJH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x52A9BE0", Offset = "0x52A81E0", VA = "0x1852A9BE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x52AA2B0", Offset = "0x52A88B0", VA = "0x1852AA2B0")]
		private void WOTWLRCFJIK(IEnumerable<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class OQUZSRRKEIJ<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private Dictionary<int, a> RNTIZLORXHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private a WFQUAAUULAQ;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual a SQGGKBYVWEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xAFB3D0", Offset = "0xAF99D0", VA = "0x180AFB3D0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1441F90", Offset = "0x1440590", VA = "0x181441F90", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5BC62F0", Offset = "0x5BC48F0", VA = "0x185BC62F0")]
		public bool VFBIVSUVFUU(a a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5C20", Offset = "0x5BC4220", VA = "0x185BC5C20")]
		public bool JHGXAYTNDRD(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5FE0", Offset = "0x5BC45E0", VA = "0x185BC5FE0")]
		public a PMDWTTTDFUR(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5AE0", Offset = "0x5BC40E0", VA = "0x185BC5AE0")]
		private bool DGVBELHIDBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5BC6350", Offset = "0x5BC4950", VA = "0x185BC6350")]
		public bool ZKJFYFPTSEI(int a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5BC64D0", Offset = "0x5BC4AD0", VA = "0x185BC64D0")]
		public OQUZSRRKEIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class GQCAVODEMTW<a>
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
		protected readonly List<Entry> GKQIFBVLYMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private a MCSMEQFYCFD;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xB5D700", Offset = "0xB5BD00", VA = "0x180B5D700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x50704F0", Offset = "0x506EAF0", VA = "0x1850704F0")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x506FC00", Offset = "0x506E200", VA = "0x18506FC00")]
		public void Add(a value, int priority)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x50712B0", Offset = "0x506F8B0", VA = "0x1850712B0")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x506FD10", Offset = "0x506E310", VA = "0x18506FD10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5070670", Offset = "0x506EC70", VA = "0x185070670")]
		public a ICKAUGEYUSD()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5070850", Offset = "0x506EE50", VA = "0x185070850")]
		protected void OLJMJQEDZLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5071500", Offset = "0x506FB00", VA = "0x185071500")]
		public GQCAVODEMTW()
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
			[Cpp2IlInjected.Address(RVA = "0x84C86A0", Offset = "0x84C6CA0", VA = "0x1884C86A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x84C8970", Offset = "0x84C6F70", VA = "0x1884C8970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x84C8880", Offset = "0x84C6E80", VA = "0x1884C8880")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x84C85F0", Offset = "0x84C6BF0", VA = "0x1884C85F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x84C88C0", Offset = "0x84C6EC0", VA = "0x1884C88C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x84C87D0", Offset = "0x84C6DD0", VA = "0x1884C87D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x84C8570", Offset = "0x84C6B70", VA = "0x1884C8570")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F43840", Offset = "0x5F41E40", VA = "0x185F43840", Slot = "4")]
		public virtual T DVXTHBSQTHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected ResourcePrefabReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface FARPAYXBOPU
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		ToolHierarchyCache WGTIZDCKQGJ
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
			[Cpp2IlInjected.Address(RVA = "0x1B252B0", Offset = "0x1B238B0", VA = "0x181B252B0")]
			public Enumerable(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x496AC10", Offset = "0x4969210", VA = "0x18496AC10")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x496AAF0", Offset = "0x49690F0", VA = "0x18496AAF0", Slot = "5")]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x496AAF0", Offset = "0x49690F0", VA = "0x18496AAF0", Slot = "4")]
			private IEnumerator<T> CDFQCYMHDZO()
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
				[Cpp2IlInjected.Address(RVA = "0x4A1C040", Offset = "0x4A1A640", VA = "0x184A1C040", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x4A1A9A0", Offset = "0x4A18FA0", VA = "0x184A1A9A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x4A1BC30", Offset = "0x4A1A230", VA = "0x184A1BC30")]
			public Enumerator(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x4A1A870", Offset = "0x4A18E70", VA = "0x184A1A870", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x4A1B430", Offset = "0x4A19A30", VA = "0x184A1B430", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x496ADA0", Offset = "0x49693A0", VA = "0x18496ADA0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> SJQVDKDLLZN;

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
		private Dictionary<Type, List<Component>> RLGFYGGMJPB;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x84CA470", Offset = "0x84C8A70", VA = "0x1884CA470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x84C9F10", Offset = "0x84C8510", VA = "0x1884C9F10")]
		private void Initialize(GameObject go, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x84C9E80", Offset = "0x84C8480", VA = "0x1884C9E80")]
		public static void Initialize(GameObject go, ToolHierarchyCache cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x84CA070", Offset = "0x84C8670", VA = "0x1884CA070")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3D743A0", Offset = "0x3D729A0", VA = "0x183D743A0")]
		public void AYXCZKEBAQW<a>(Action<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3D74610", Offset = "0x3D72C10", VA = "0x183D74610")]
		public b OOHUERJMHWX<b>(bool a = false) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3D74560", Offset = "0x3D72B60", VA = "0x183D74560")]
		public Enumerable<c> MPBXRCZVZBC<c>(bool a = false) where c : class
		{
			return default(Enumerable<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x84CA080", Offset = "0x84C8680", VA = "0x1884CA080")]
		public List<Component> YIQOHYWYXJV(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x84C9D90", Offset = "0x84C8390", VA = "0x1884C9D90", Slot = "4")]
		public bool Equals(ToolHierarchyCache x, ToolHierarchyCache y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x84C9E10", Offset = "0x84C8410", VA = "0x1884C9E10", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache obj)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class FLITZRULQDC<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private int XOWCOHLSJQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int MNWYSTJANHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private List<a> NFDVDUQXEUJ;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2951E70", Offset = "0x2950470", VA = "0x182951E70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public a WEELCONHWNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x4F34BA0", Offset = "0x4F331A0", VA = "0x184F34BA0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public a WDJSEUGONVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x4F34620", Offset = "0x4F32C20", VA = "0x184F34620")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public a JUMGNJGMISZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x4F34980", Offset = "0x4F32F80", VA = "0x184F34980")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x4F34F70", Offset = "0x4F33570", VA = "0x184F34F70")]
		public FLITZRULQDC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4F342D0", Offset = "0x4F328D0", VA = "0x184F342D0")]
		public void Add(a command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x4F34560", Offset = "0x4F32B60", VA = "0x184F34560")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4F34EA0", Offset = "0x4F334A0", VA = "0x184F34EA0")]
		public void XDQGHHJDLSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x4F34EF0", Offset = "0x4F334F0", VA = "0x184F34EF0")]
		public void ZVSOWPITTOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x4F34D80", Offset = "0x4F33380", VA = "0x184F34D80")]
		public void UQUSSOHWXFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4F34C30", Offset = "0x4F33230", VA = "0x184F34C30")]
		public List<a> UCEGWCSALAB()
		{
			return null;
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class NNJJTMKQPQG<a>
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
		private readonly Dictionary<object, PrioritizedData> RNTIZLORXHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly EqualityComparer<a> HGASLFJGVVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private a WFQUAAUULAQ;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual a SQGGKBYVWEV
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xF331E0", Offset = "0xF317E0", VA = "0x180F331E0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x5A7B280", Offset = "0x5A79880", VA = "0x185A7B280", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool LQAQCFUEYYX
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x5A7B1E0", Offset = "0x5A797E0", VA = "0x185A7B1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public object KXCIREMNHPX
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5A7B360", Offset = "0x5A79960", VA = "0x185A7B360")]
		public bool VFBIVSUVFUU(a a, object b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5A7B000", Offset = "0x5A79600", VA = "0x185A7B000")]
		public bool JHGXAYTNDRD(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5A7C530", Offset = "0x5A7AB30", VA = "0x185A7C530")]
		public bool ZKJFYFPTSEI(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5A781A0", Offset = "0x5A767A0", VA = "0x185A781A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5A79A50", Offset = "0x5A78050", VA = "0x185A79A50")]
		private bool DGVBELHIDBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5A7CFF0", Offset = "0x5A7B5F0", VA = "0x185A7CFF0")]
		public NNJJTMKQPQG()
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
