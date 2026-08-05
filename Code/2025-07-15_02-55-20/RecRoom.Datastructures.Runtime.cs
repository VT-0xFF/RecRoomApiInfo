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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x80BD7A0", Offset = "0x80BC3A0", VA = "0x1880BD7A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NJPBOFIPKFD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x230C7E0", Offset = "0x230B3E0", VA = "0x18230C7E0")]
	public NJPBOFIPKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, LKPCPIPPIDO, OPFAJFCMNPJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FNNEEIFKEML);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x80BF3C0", Offset = "0x80BDFC0", VA = "0x1880BF3C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80BF380", Offset = "0x80BDF80", VA = "0x1880BF380")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80BF400", Offset = "0x80BE000", VA = "0x1880BF400")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80BF5B0", Offset = "0x80BE1B0", VA = "0x1880BF5B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80BF520", Offset = "0x80BE120", VA = "0x1880BF520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAB55B0", Offset = "0xAB41B0", VA = "0x180AB55B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAB56A0", Offset = "0xAB42A0", VA = "0x180AB56A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80BF340", Offset = "0x80BDF40", VA = "0x1880BF340")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80BF490", Offset = "0x80BE090", VA = "0x1880BF490")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80BEEA0", Offset = "0x80BDAA0", VA = "0x1880BEEA0")]
	public void CopyBounds(SavedExtents IIOGPDPGOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80BF290", Offset = "0x80BDE90", VA = "0x1880BF290")]
	public void SetLocalSpaceBounds(Bounds OEMBDBJNEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x16637F0", Offset = "0x16623F0", VA = "0x1816637F0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80BF280", Offset = "0x80BDE80", VA = "0x1880BF280")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80BEED0", Offset = "0x80BDAD0", VA = "0x1880BEED0")]
	private void IGFAFNLHBMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80BF080", Offset = "0x80BDC80", VA = "0x1880BF080")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80BE830", Offset = "0x80BD430", VA = "0x1880BE830")]
	public static void CalculateLocalBoundsFor(GameObject HLOIBGDKPID, [Out] Bounds OEMBDBJNEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80BE770", Offset = "0x80BD370", VA = "0x1880BE770")]
	private static void BMNMLEIOCDE(Bounds MAKDDCFIOBO, Color FBNAMAEDFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80BF2B0", Offset = "0x80BDEB0", VA = "0x1880BF2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1B107F0", Offset = "0x1B0F3F0", VA = "0x181B107F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5C30640", Offset = "0x5C2F240", VA = "0x185C30640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public virtual void GHAGJBJDKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
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
	[NJPBOFIPKFD]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5C30270", Offset = "0x5C2EE70", VA = "0x185C30270", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C2F0C0", Offset = "0x5C2DCC0", VA = "0x185C2F0C0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C305A0", Offset = "0x5C2F1A0", VA = "0x185C305A0")]
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
	private sealed class NKFIELHHNMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NKFIELHHNMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x571DBE0", Offset = "0x571C7E0", VA = "0x18571DBE0")]
		internal int KFKHOCDFEPK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[NJPBOFIPKFD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x49076A0", Offset = "0x49062A0", VA = "0x1849076A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x49076E0", Offset = "0x49062E0", VA = "0x1849076E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x49075C0", Offset = "0x49061C0", VA = "0x1849075C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey DHCHBFGMFFD]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4907640", Offset = "0x4906240", VA = "0x184907640", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x49074C0", Offset = "0x49060C0", VA = "0x1849074C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49071E0", Offset = "0x4905DE0", VA = "0x1849071E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49066D0", Offset = "0x49052D0", VA = "0x1849066D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x49066A0", Offset = "0x49052A0", VA = "0x1849066A0", Slot = "14")]
	protected virtual string NBOMFMPLPOH(TKeyVal KGFGMOBGFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4906560", Offset = "0x4905160", VA = "0x184906560", Slot = "4")]
	public bool ContainsKey(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4907390", Offset = "0x4905F90", VA = "0x184907390", Slot = "5")]
	public bool TryGetValue(TKey DHCHBFGMFFD, [Out] TVal BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x49065A0", Offset = "0x49051A0", VA = "0x1849065A0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49065A0", Offset = "0x49051A0", VA = "0x1849065A0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x49073D0", Offset = "0x4905FD0", VA = "0x1849073D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x4893BE0", Offset = "0x48927E0", VA = "0x184893BE0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[NJPBOFIPKFD]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C31CE0", Offset = "0x5C308E0", VA = "0x185C31CE0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5C31630", Offset = "0x5C30230", VA = "0x185C31630", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5C30CB0", Offset = "0x5C2F8B0", VA = "0x185C30CB0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class PPKIPADDOJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct OOIGLKHIAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T AHLMJDKCEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float KHOJKKJFMGB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int BNMEKJOLBMD = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float KMIBNIBDMHM = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly OOIGLKHIAJD[] COJHNLDFDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int KKCDECKPABN;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float JFAAAANLHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD2BA80", Offset = "0xD2A680", VA = "0x180D2BA80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD6A3F0", Offset = "0xD68FF0", VA = "0x180D6A3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T HMJMELILNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5A2AEA0", Offset = "0x5A29AA0", VA = "0x185A2AEA0")]
	protected PPKIPADDOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5A2AE20", Offset = "0x5A29A20", VA = "0x185A2AE20")]
	protected PPKIPADDOJM(int PFHGPMHBODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5A2AD40", Offset = "0x5A29940", VA = "0x185A2AD40")]
	public void NDGLNAHKHEG(float HCMFNJGJPMC, T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DFJPKPLLKOO(float BLMNNDJKEGK, float KHHHLJHCPDH, [Out] T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool DKFFBEIFFOJ(float BLMNNDJKEGK, float KHHHLJHCPDH, [Out] T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5A2ABA0", Offset = "0x5A297A0", VA = "0x185A2ABA0")]
	public void HAGLLFMPLGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NPBMHBPDPEJ : PPKIPADDOJM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80BD4C0", Offset = "0x80BC0C0", VA = "0x1880BD4C0", Slot = "4")]
	public override bool DFJPKPLLKOO(float BLMNNDJKEGK, float KHHHLJHCPDH, [Out] Vector3 BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80BD620", Offset = "0x80BC220", VA = "0x1880BD620", Slot = "5")]
	public override bool DKFFBEIFFOJ(float BLMNNDJKEGK, float KHHHLJHCPDH, [Out] Vector3 BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80BD760", Offset = "0x80BC360", VA = "0x1880BD760")]
	public NPBMHBPDPEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JNIABLJPGDL
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE990", Offset = "0x3CCD590", VA = "0x183CCE990")]
	public static OIJCPJFMFHD<T1, T2> FOGKIHKKOLG<T1, T2>(T1 PKDLKDEJHNG, T2 HOFBCGMDPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CCEA10", Offset = "0x3CCD610", VA = "0x183CCEA10")]
	public static LBKLJEKPGHF<T1, T2, T3> FOGKIHKKOLG<T1, T2, T3>(T1 PKDLKDEJHNG, T2 HOFBCGMDPAI, T3 BNECDPPOHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x56DE620", Offset = "0x56DD220", VA = "0x1856DE620")]
	internal static int BHINAPEOKCB(int NIBFLLPPHPF, int PPGMDGBMMJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7249F10", Offset = "0x7248B10", VA = "0x187249F10")]
	internal static int BHINAPEOKCB(int NIBFLLPPHPF, int PPGMDGBMMJF, int FNBOLKCKKLM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OIJCPJFMFHD<T1, T2> : IComparable<OIJCPJFMFHD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 NPAKKOCGOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 LPKHHHOBJPA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x586DD10", Offset = "0x586C910", VA = "0x18586DD10")]
	public OIJCPJFMFHD(T1 PKDLKDEJHNG, T2 HOFBCGMDPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x586C350", Offset = "0x586AF50", VA = "0x18586C350", Slot = "4")]
	public int CompareTo(OIJCPJFMFHD<T1, T2> IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x586CC90", Offset = "0x586B890", VA = "0x18586CC90", Slot = "0")]
	public override bool Equals(object IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x586D270", Offset = "0x586BE70", VA = "0x18586D270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x586D8E0", Offset = "0x586C4E0", VA = "0x18586D8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LBKLJEKPGHF<T1, T2, T3> : IComparable<LBKLJEKPGHF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 NPAKKOCGOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 LPKHHHOBJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 MOLNCAEIBPH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x54528C0", Offset = "0x54514C0", VA = "0x1854528C0")]
	public LBKLJEKPGHF(T1 PKDLKDEJHNG, T2 HOFBCGMDPAI, T3 BNECDPPOHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5451FA0", Offset = "0x5450BA0", VA = "0x185451FA0", Slot = "4")]
	public int CompareTo(LBKLJEKPGHF<T1, T2, T3> IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5452200", Offset = "0x5450E00", VA = "0x185452200", Slot = "0")]
	public override bool Equals(object IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x54524D0", Offset = "0x54510D0", VA = "0x1854524D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5452710", Offset = "0x5451310", VA = "0x185452710", Slot = "3")]
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
	public AnimationCurve AAENAIODIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T NJEMBDHJLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x13A8BF0", Offset = "0x13A77F0", VA = "0x1813A8BF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T JKJPBIBONDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2E442D0", Offset = "0x2E42ED0", VA = "0x182E442D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2E43FD0", Offset = "0x2E42BD0", VA = "0x182E43FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float PIEJIAHOGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAAF0F0", Offset = "0xAADCF0", VA = "0x180AAF0F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA570", Offset = "0x5EF9170", VA = "0x185EFA570")]
	public T BODGMMLDPOO(float KJCIKLJPCMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA780", Offset = "0x5EF9380", VA = "0x185EFA780")]
	public T OMDIGKPKPFP(float KJCIKLJPCMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EMNPFBPPFAL(T OHEOONFKODG, T GOPANKCDGOD, float KJCIKLJPCMB);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x80BB9A0", Offset = "0x80BA5A0", VA = "0x1880BB9A0", Slot = "4")]
	protected override float EMNPFBPPFAL(float OHEOONFKODG, float GOPANKCDGOD, float KJCIKLJPCMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x80BB9E0", Offset = "0x80BA5E0", VA = "0x1880BB9E0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1962D60", Offset = "0x1961960", VA = "0x181962D60", Slot = "4")]
	protected override Vector3 EMNPFBPPFAL(Vector3 OHEOONFKODG, Vector3 GOPANKCDGOD, float KJCIKLJPCMB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x80C03D0", Offset = "0x80BEFD0", VA = "0x1880C03D0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x80BB830", Offset = "0x80BA430", VA = "0x1880BB830", Slot = "4")]
	protected override Color EMNPFBPPFAL(Color OHEOONFKODG, Color GOPANKCDGOD, float KJCIKLJPCMB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x80BB8F0", Offset = "0x80BA4F0", VA = "0x1880BB8F0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MOAAOIEAPKE : DBOLDPCBHFA<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80BD270", Offset = "0x80BBE70", VA = "0x1880BD270")]
	public MOAAOIEAPKE(int FJNGONEOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x80BD200", Offset = "0x80BBE00", VA = "0x1880BD200", Slot = "6")]
	protected override uint ALOIKJDKALK(uint FNNEEIFKEML, string BKMPCFIAHIG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NLNOJNACOLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable MFAGMJBMEEP;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public NLNOJNACOLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BNHGKLBECAN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> NJIICALBMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DMJNDCJJEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int FIOPKCPLMDD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x56E0740", Offset = "0x56DF340", VA = "0x1856E0740")]
	private BNHGKLBECAN(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EFIJPLGAKIO, int PMNHDPMAGHP, int MANPAFALMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x66F9AF0", Offset = "0x66F86F0", VA = "0x1866F9AF0")]
	public static BNHGKLBECAN<T> MJMNOIPJNFN()
	{
		return default(BNHGKLBECAN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x66FA8E0", Offset = "0x66F94E0", VA = "0x1866FA8E0")]
	public (int, int, Task<T>) OFOKAIPFEKM(int JGGIBDMAPLG, [Optional] CancellationToken JHCOCAANJDL, double DJMONOPAJCJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x66FB5E0", Offset = "0x66FA1E0", VA = "0x1866FB5E0")]
	public void OLIOMIHMCEN(int JGGIBDMAPLG, int MANPAFALMMC, [In] T ABEFNIJCBBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KCMGJJOFIGP
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x80BBDE0", Offset = "0x80BA9E0", VA = "0x1880BBDE0")]
	public static BNHGKLBECAN<DIKEICNGGBM> MJMNOIPJNFN()
	{
		return default(BNHGKLBECAN<DIKEICNGGBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x80BBE30", Offset = "0x80BAA30", VA = "0x1880BBE30")]
	public static void OLIOMIHMCEN([In] this BNHGKLBECAN<DIKEICNGGBM> JBDFDFABHKD, int JGGIBDMAPLG, int MANPAFALMMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class EEHMPKPIKGH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> LNFAKPGNJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> CPLIOHOLEAH;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x443AEA0", Offset = "0x4439AA0", VA = "0x18443AEA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OBFGHCLKFON
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> MLFPECEOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x48CE570", Offset = "0x48CD170", VA = "0x1848CE570", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> OGINALBFHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x48CE5B0", Offset = "0x48CD1B0", VA = "0x1848CE5B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x48CE510", Offset = "0x48CD110", VA = "0x1848CE510", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x48CE610", Offset = "0x48CD210", VA = "0x1848CE610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x48CE050", Offset = "0x48CCC50", VA = "0x1848CE050")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x48CDCA0", Offset = "0x48CC8A0", VA = "0x1848CDCA0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x48CE350", Offset = "0x48CCF50", VA = "0x1848CE350", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x48CDB30", Offset = "0x48CC730", VA = "0x1848CDB30", Slot = "9")]
	public void Add(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x48CDAE0", Offset = "0x48CC6E0", VA = "0x1848CDAE0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x48CDD00", Offset = "0x48CC900", VA = "0x1848CDD00", Slot = "8")]
	public bool ContainsKey(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x48CDD70", Offset = "0x48CC970", VA = "0x1848CDD70", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x48CE280", Offset = "0x48CCE80", VA = "0x1848CE280", Slot = "10")]
	public bool Remove(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x48CE2A0", Offset = "0x48CCEA0", VA = "0x1848CE2A0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x48CE3A0", Offset = "0x48CCFA0", VA = "0x1848CE3A0", Slot = "11")]
	public bool TryGetValue(TKey DHCHBFGMFFD, [Out] TVal BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x48CDEA0", Offset = "0x48CCAA0", VA = "0x1848CDEA0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x48CDDA0", Offset = "0x48CC9A0", VA = "0x1848CDDA0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] COJHNLDFDFB, int FPBBDMPMMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x48CDE50", Offset = "0x48CCA50", VA = "0x1848CDE50")]
	public bool GLNNPKODOFD(TVal DHCHBFGMFFD, [Out] TKey BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x48CDFB0", Offset = "0x48CCBB0", VA = "0x1848CDFB0")]
	private void IEGMECIJIBD(TKey DHCHBFGMFFD, TVal PINMHDANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x48CDC00", Offset = "0x48CC800", VA = "0x1848CDC00")]
	private void BOCLDEKNEOL(TKey DHCHBFGMFFD, TVal PINMHDANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x48CE0E0", Offset = "0x48CCCE0", VA = "0x1848CE0E0")]
	private bool KHNDLLOAGKB(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x48CE3E0", Offset = "0x48CCFE0", VA = "0x1848CE3E0")]
	public EEHMPKPIKGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class CIPINLIIGHP<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CIPINLIIGHP<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x1474260", Offset = "0x1472E60", VA = "0x181474260", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x496A1F0", Offset = "0x4968DF0", VA = "0x18496A1F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x496ADE0", Offset = "0x49699E0", VA = "0x18496ADE0")]
		public Enumerator(CIPINLIIGHP<T> HAPOFGGDNGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x49698A0", Offset = "0x49684A0", VA = "0x1849698A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4969ED0", Offset = "0x4968AD0", VA = "0x184969ED0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4969CE0", Offset = "0x49688E0", VA = "0x184969CE0")]
		private void ONFCACFKIHD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] JMHKPAOIEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int FAHOKHGHPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HALHNLODLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int LAHAJPPAFND;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C2FA20", Offset = "0x6C2E620", VA = "0x186C2FA20", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D2C0", Offset = "0x6C2BEC0", VA = "0x186C2D2C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F530", Offset = "0x6C2E130", VA = "0x186C2F530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F9A0", Offset = "0x6C2E5A0", VA = "0x186C2F9A0")]
	public CIPINLIIGHP(int FJNGONEOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EF70", Offset = "0x6C2DB70", VA = "0x186C2EF70")]
	public void NDGLNAHKHEG(T KJCIKLJPCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D9F0", Offset = "0x6C2C5F0", VA = "0x186C2D9F0")]
	public void MDMBKAPGMLH(IEnumerable<T> BNBCBHJAJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C8B0", Offset = "0x6C2B4B0", VA = "0x186C2C8B0")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C810", Offset = "0x6C2B410", VA = "0x186C2C810")]
	public void FAKAIFMOFOE(int NKGPOLKDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CE90", Offset = "0x6C2BA90", VA = "0x186C2CE90")]
	public void IMHILHBHKJC(T[] COJHNLDFDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EDD0", Offset = "0x6C2D9D0", VA = "0x186C2EDD0")]
	public Enumerator MIEHOANGBJG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F900", Offset = "0x6C2E500", VA = "0x186C2F900", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F900", Offset = "0x6C2E500", VA = "0x186C2F900", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D7F0", Offset = "0x6C2C3F0", VA = "0x186C2D7F0")]
	private int KHBGPMPJKGD(int LCCBBMBENOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F3B0", Offset = "0x6C2DFB0", VA = "0x186C2F3B0")]
	private int OPLCLIGOKEP(int LCCBBMBENOH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JDABNAKKPGL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> BDCEKNBDFGJ(TRequest HPBJFJONIPC, CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum GCDDNJLKPED
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class CFJKCILLBMO
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float DFPFKFIABKA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan PPHMNCBPAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int IPLPDMOFMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GCDDNJLKPED FHHNIDBKGGA;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly CFJKCILLBMO JOFMPALJJOB;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float JKKHMJFMMHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6B69260", Offset = "0x6B67E60", VA = "0x186B69260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan ENJANEBDCBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6B692D0", Offset = "0x6B67ED0", VA = "0x186B692D0")]
		public CFJKCILLBMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct MNEFGAAOMFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest HPBJFJONIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken JHCOCAANJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> BCPNFKHFIOJ;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x56A6530", Offset = "0x56A5130", VA = "0x1856A6530")]
		public MNEFGAAOMFL(TRequest HPBJFJONIPC, TaskCompletionSource<TResult> BCPNFKHFIOJ, CancellationToken JHCOCAANJDL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct OEGLEILKJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JDABNAKKPGL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5859140", Offset = "0x5857D40", VA = "0x185859140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x58598C0", Offset = "0x58584C0", VA = "0x1858598C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct PNNCGCOGGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public JDABNAKKPGL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MNEFGAAOMFL <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B370", Offset = "0x5A19F70", VA = "0x185A1B370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5A1BEF0", Offset = "0x5A1AAF0", VA = "0x185A1BEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource KEMGNEENFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<MNEFGAAOMFL> DIOHLGPMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CFJKCILLBMO IEDOCEAEHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly BDCEKNBDFGJ BBLDOHCNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task NCMADCDDMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int KCNFONDLFPA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x52AA110", Offset = "0x52A8D10", VA = "0x1852AA110")]
	public JDABNAKKPGL(BDCEKNBDFGJ BBLDOHCNAFM, [Optional] CFJKCILLBMO IEDOCEAEHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x52A96D0", Offset = "0x52A82D0", VA = "0x1852A96D0")]
	public Task<TResult> JDDHDMIPONE(TRequest HPBJFJONIPC, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x52A8950", Offset = "0x52A7550", VA = "0x1852A8950")]
	private void BGNMGNAEPIO(MNEFGAAOMFL CPBDOFIBDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x52A8B80", Offset = "0x52A7780", VA = "0x1852A8B80")]
	[AsyncStateMachine(typeof(JDABNAKKPGL<, >.OEGLEILKJOD))]
	private Task CAMCPJODIAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x52A91F0", Offset = "0x52A7DF0", VA = "0x1852A91F0")]
	private MNEFGAAOMFL IMILALEIBKB()
	{
		return default(MNEFGAAOMFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x52A9DB0", Offset = "0x52A89B0", VA = "0x1852A9DB0")]
	[AsyncStateMachine(typeof(JDABNAKKPGL<, >.PNNCGCOGGIL))]
	private Task LEEDFPCCBEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x52A8C90", Offset = "0x52A7890", VA = "0x1852A8C90")]
	private void HILEGNPONAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x52A8C50", Offset = "0x52A7850", VA = "0x1852A8C50", Slot = "4")]
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
public class PDHNBBAKCGG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> ADEANPNALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> FHNNLIJEOHB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x443AEA0", Offset = "0x4439AA0", VA = "0x18443AEA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OBFGHCLKFON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x584A440", Offset = "0x5849040", VA = "0x18584A440", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x59BEAA0", Offset = "0x59BD6A0", VA = "0x1859BEAA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DD2540", Offset = "0x4DD1140", VA = "0x184DD2540", Slot = "11")]
	public void Add(T BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x59BE280", Offset = "0x59BCE80", VA = "0x1859BE280")]
	public bool BFMHMFJPMDI(T BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x59BE920", Offset = "0x59BD520", VA = "0x1859BE920", Slot = "15")]
	public bool Remove(T BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x59BE4B0", Offset = "0x59BD0B0", VA = "0x1859BE4B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E28820", Offset = "0x4E27420", VA = "0x184E28820", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x59BE3E0", Offset = "0x59BCFE0", VA = "0x1859BE3E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x59BE440", Offset = "0x59BD040", VA = "0x1859BE440", Slot = "13")]
	public bool Contains(T BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x59BE480", Offset = "0x59BD080", VA = "0x1859BE480", Slot = "14")]
	public void CopyTo(T[] COJHNLDFDFB, int FPBBDMPMMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5420220", Offset = "0x541EE20", VA = "0x185420220", Slot = "6")]
	public int IndexOf(T BHNJKAEPJMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x59BE530", Offset = "0x59BD130", VA = "0x1859BE530", Slot = "7")]
	public void Insert(int LCCBBMBENOH, T BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x59BE6D0", Offset = "0x59BD2D0", VA = "0x1859BE6D0", Slot = "8")]
	public void RemoveAt(int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x59BE9B0", Offset = "0x59BD5B0", VA = "0x1859BE9B0")]
	public PDHNBBAKCGG()
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
			[Cpp2IlInjected.Address(RVA = "0x2C955D0", Offset = "0x2C941D0", VA = "0x182C955D0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D50", Offset = "0xAB1950", VA = "0x180AB2D50")]
		public SerializedGuid([In] Guid FHNOHJCOOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x80BF740", Offset = "0x80BE340", VA = "0x1880BF740")]
		public static SerializedGuid FHMCNOPMNKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x80BF7D0", Offset = "0x80BE3D0", VA = "0x1880BF7D0")]
		public static SerializedGuid JAJJLNIDLAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x80BF840", Offset = "0x80BE440", VA = "0x1880BF840")]
		public bool NNPPJEMMDAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x80BF920", Offset = "0x80BE520", VA = "0x1880BF920", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x80BF8A0", Offset = "0x80BE4A0", VA = "0x1880BF8A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80BF670", Offset = "0x80BE270", VA = "0x1880BF670", Slot = "7")]
		public bool Equals(SerializedGuid IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x80BF6B0", Offset = "0x80BE2B0", VA = "0x1880BF6B0", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x80BF7C0", Offset = "0x80BE3C0", VA = "0x1880BF7C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x80BF640", Offset = "0x80BE240", VA = "0x1880BF640", Slot = "6")]
		public int CompareTo(SerializedGuid IIOGPDPGOLB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FKPEPIBDFKP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type BINNEKBOEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string LAKAJMHOHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool GJPMDNFAKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool NLKPAAAJLHE;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x80BB930", Offset = "0x80BA530", VA = "0x1880BB930")]
	public FKPEPIBDFKP(Type FCEHOBDEEEA, string DLHECEBNDJL, bool BLFDDFKFLOL = false, bool GBIICNPBNLC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JOLDDFBCDLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int IKBIIBBMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> HMIADGDIBFK(float HCMFNJGJPMC, [Optional] float? NLNHDLNBDEH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLHHKKFKMGP(float HCMFNJGJPMC, T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAGLLFMPLGJ();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class AKKLAFILLDA<T> : JOLDDFBCDLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class NGLANKLOBFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float FCMDJLAJAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T AHLMJDKCEID;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NGLANKLOBFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HOKBANPBJHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HOKBANPBJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4FAD530", Offset = "0x4FAC130", VA = "0x184FAD530")]
		internal bool DDOGABLAHEH(NGLANKLOBFE sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float DJCBGPMGOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float DIFNLDKCLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<NGLANKLOBFE> MPFONBMLLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private HKDOFLHGMIJ<NGLANKLOBFE> KHHIGDLOIPA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IKBIIBBMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5182030", Offset = "0x5180C30", VA = "0x185182030", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5182AF0", Offset = "0x51816F0", VA = "0x185182AF0")]
	public AKKLAFILLDA(float IONOPDOHIOB, float NJMCPDGDHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5182980", Offset = "0x5181580", VA = "0x185182980", Slot = "6")]
	public bool LLHHKKFKMGP(float HCMFNJGJPMC, T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5182530", Offset = "0x5181130", VA = "0x185182530", Slot = "5")]
	public IEnumerable<T> HMIADGDIBFK(float HCMFNJGJPMC, float? NLNHDLNBDEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x51821E0", Offset = "0x5180DE0", VA = "0x1851821E0", Slot = "7")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x51820A0", Offset = "0x5180CA0", VA = "0x1851820A0")]
	private void CJHKKMCNMNG(float HCMFNJGJPMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class PNHHLNBLLKA<T> : JOLDDFBCDLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct EDGEECBENJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T AHLMJDKCEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float FCMDJLAJAGK;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x48CD370", Offset = "0x48CBF70", VA = "0x1848CD370")]
		public EDGEECBENJL(T BKMPCFIAHIG, float HCMFNJGJPMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class MGDHMIBOAOG : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public PNHHLNBLLKA<T> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public MGDHMIBOAOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5671860", Offset = "0x5670460", VA = "0x185671860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5671BD0", Offset = "0x56707D0", VA = "0x185671BD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5671A00", Offset = "0x5670600", VA = "0x185671A00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4F7AC00", Offset = "0x4F79800", VA = "0x184F7AC00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float IONOPDOHIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float NJMCPDGDHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<EDGEECBENJL> MPFONBMLLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FAHOKHGHPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int BHPJNPKMECB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int IKBIIBBMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5C760", Offset = "0xA5B360", VA = "0x180A5C760", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5A1ABE0", Offset = "0x5A197E0", VA = "0x185A1ABE0")]
	public PNHHLNBLLKA(float IONOPDOHIOB, float NJMCPDGDHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A420", Offset = "0x5A19020", VA = "0x185A1A420", Slot = "6")]
	public bool LLHHKKFKMGP(float HCMFNJGJPMC, T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A0C0", Offset = "0x5A18CC0", VA = "0x185A1A0C0", Slot = "8")]
	public int EHJGNPNMLGA(float HCMFNJGJPMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A2C0", Offset = "0x5A18EC0", VA = "0x185A1A2C0", Slot = "5")]
	[IteratorStateMachine(typeof(PNHHLNBLLKA<>.MGDHMIBOAOG))]
	public IEnumerable<T> HMIADGDIBFK(float HCMFNJGJPMC, float? NLNHDLNBDEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A0F0", Offset = "0x5A18CF0", VA = "0x185A1A0F0", Slot = "7")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A130", Offset = "0x5A18D30", VA = "0x185A1A130")]
	private void HCPBLAKDOEG(float HCMFNJGJPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A920", Offset = "0x5A19520", VA = "0x185A1A920")]
	private EDGEECBENJL OMMMFGAEMPD()
	{
		return default(EDGEECBENJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LHKIACFOHBL<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct LMBFKLFGKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long HGPMCPAPLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long HOMOOJBBBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int BOENOAMMAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int BLJJOGGOEJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool HJFNMIOINJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string ACMDAHGAHLA;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x546A450", Offset = "0x5469050", VA = "0x18546A450")]
		public LMBFKLFGKML(long HGPMCPAPLBF, int BOENOAMMAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x546A420", Offset = "0x5469020", VA = "0x18546A420")]
		public LMBFKLFGKML(long HGPMCPAPLBF, long HOMOOJBBBGJ, int BOENOAMMAOO, int BLJJOGGOEJF, bool HJFNMIOINJB, string ACMDAHGAHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x546A3D0", Offset = "0x5468FD0", VA = "0x18546A3D0")]
		public int OCJHLMLEINB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x546A350", Offset = "0x5468F50", VA = "0x18546A350")]
		public int LKADHDJPHPL(int IJGLBJCHNML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x546A370", Offset = "0x5468F70", VA = "0x18546A370")]
		public double NOFNEEOBAMH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x546A2B0", Offset = "0x5468EB0", VA = "0x18546A2B0")]
		public LMBFKLFGKML KOPHKGDGIFC(long HOMOOJBBBGJ, int BLJJOGGOEJF)
		{
			return default(LMBFKLFGKML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class NJLPFCODNGJ : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct GJHNCOJMOAB<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public NJLPFCODNGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<NJLPFCODNGJ, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private NJLPFCODNGJ <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4EA7340", Offset = "0x4EA5F40", VA = "0x184EA7340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4D7C680", Offset = "0x4D7B280", VA = "0x184D7C680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey DICGCMOFCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly LHKIACFOHBL<TKey> LFPPCCOIMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly PEOHNMCPNIJ GDLIBGFAMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<NJLPFCODNGJ> ADNBMPHJFEC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string IMJPMNFOOMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x57123F0", Offset = "0x5710FF0", VA = "0x1857123F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<NJLPFCODNGJ> LPOCBIDNPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5712270", Offset = "0x5710E70", VA = "0x185712270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public LMBFKLFGKML JFPNKKABJMB
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5712070", Offset = "0x5710C70", VA = "0x185712070")]
			[CompilerGenerated]
			get
			{
				return default(LMBFKLFGKML);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5712420", Offset = "0x5711020", VA = "0x185712420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5712450", Offset = "0x5711050", VA = "0x185712450")]
		internal NJLPFCODNGJ(LHKIACFOHBL<TKey> LFPPCCOIMLK, TKey DHCHBFGMFFD, PEOHNMCPNIJ GDLIBGFAMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x57122A0", Offset = "0x5710EA0", VA = "0x1857122A0")]
		public NJLPFCODNGJ GLILNHGKFNI(TKey DHCHBFGMFFD, [Optional] PEOHNMCPNIJ? EJANKKNMKIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x43B3070", Offset = "0x43B1C70", VA = "0x1843B3070")]
		[AsyncStateMachine(typeof(GJHNCOJMOAB<>))]
		public Task<T> HCPFJOLLCKO<T>(TKey DHCHBFGMFFD, Func<NJLPFCODNGJ, Task<T>> LOCAHCLFLKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5712090", Offset = "0x5710C90", VA = "0x185712090", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class PIGOLEJOAEG : IEnumerable<(TKey, List<TKey>, LMBFKLFGKML)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LMBFKLFGKML)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, LMBFKLFGKML timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LHKIACFOHBL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, LMBFKLFGKML timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, LMBFKLFGKML) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0A40", Offset = "0x2C9F640", VA = "0x182CA0A40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LMBFKLFGKML));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x59CBD00", Offset = "0x59CA900", VA = "0x1859CBD00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0B30", Offset = "0x2C9F730", VA = "0x182CA0B30")]
		[DebuggerHidden]
		public PIGOLEJOAEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4DF40C0", Offset = "0x4DF2CC0", VA = "0x184DF40C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x59CB870", Offset = "0x59CA470", VA = "0x1859CB870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x59CB820", Offset = "0x59CA420", VA = "0x1859CB820")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x59CBCB0", Offset = "0x59CA8B0", VA = "0x1859CBCB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x59CBBF0", Offset = "0x59CA7F0", VA = "0x1859CBBF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LMBFKLFGKML)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x448E500", Offset = "0x448D100", VA = "0x18448E500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IKDAIHJCBOH : IEnumerable<(TKey, List<TKey>, LMBFKLFGKML)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LMBFKLFGKML)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, LMBFKLFGKML timerEntry) <>2__current;

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
		private NJLPFCODNGJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public NJLPFCODNGJ <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LHKIACFOHBL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<NJLPFCODNGJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, LMBFKLFGKML timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, LMBFKLFGKML) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0A40", Offset = "0x2C9F640", VA = "0x182CA0A40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LMBFKLFGKML));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x50A6430", Offset = "0x50A5030", VA = "0x1850A6430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0B30", Offset = "0x2C9F730", VA = "0x182CA0B30")]
		[DebuggerHidden]
		public IKDAIHJCBOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x50A6490", Offset = "0x50A5090", VA = "0x1850A6490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x50A5B70", Offset = "0x50A4770", VA = "0x1850A5B70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x50A5AB0", Offset = "0x50A46B0", VA = "0x1850A5AB0")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x50A5B10", Offset = "0x50A4710", VA = "0x1850A5B10")]
		private void KBNMMFGEPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x50A63E0", Offset = "0x50A4FE0", VA = "0x1850A63E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x50A62D0", Offset = "0x50A4ED0", VA = "0x1850A62D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LMBFKLFGKML)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x50A63B0", Offset = "0x50A4FB0", VA = "0x1850A63B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, LMBFKLFGKML, PEOHNMCPNIJ> JDIPGGIDMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, LMBFKLFGKML, PEOHNMCPNIJ> OLAGFMGEIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<LHKIACFOHBL<TKey>, PEOHNMCPNIJ> DMJLEFDAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NJLPFCODNGJ OAAGBKOLGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool KBLIMDOOPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int LKJPAEPLHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch PFDBICJAICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int JNCIONMGFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string BGCHGNBJJCH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NJLPFCODNGJ DBGEODAOLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string IMJPMNFOOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x54625C0", Offset = "0x54611C0", VA = "0x1854625C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5462620", Offset = "0x5461220", VA = "0x185462620")]
	public LHKIACFOHBL(TKey BJNAGFOOCMA, PEOHNMCPNIJ GDLIBGFAMED, [Optional] int? BOENOAMMAOO, [Optional][CanBeNull] Stopwatch PFDBICJAICJ, [Optional] Action<TKey, LMBFKLFGKML, PEOHNMCPNIJ> JDIPGGIDMKE, [Optional] Action<TKey, LMBFKLFGKML, PEOHNMCPNIJ> OLAGFMGEIKF, [Optional] Action<LHKIACFOHBL<TKey>, PEOHNMCPNIJ> DMJLEFDAFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5462350", Offset = "0x5460F50", VA = "0x185462350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x54623E0", Offset = "0x5460FE0", VA = "0x1854623E0")]
	[IteratorStateMachine(typeof(LHKIACFOHBL<>.PIGOLEJOAEG))]
	public IEnumerable<(TKey, List<TKey>, LMBFKLFGKML)> FMBOAIKDHBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5462470", Offset = "0x5461070", VA = "0x185462470")]
	[IteratorStateMachine(typeof(LHKIACFOHBL<>.IKDAIHJCBOH))]
	private IEnumerable<(TKey, List<TKey>, LMBFKLFGKML)> FMBOAIKDHBK(List<TKey> OKJOHKDNPGK, NJLPFCODNGJ CPPEDLNOHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5462540", Offset = "0x5461140", VA = "0x185462540")]
	private (long, int) KALEBDJCKDN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class HHAPIDIPBKF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut LNIBKOKGCBA(LHKIACFOHBL<TKey> LFPPCCOIMLK);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected HHAPIDIPBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GMNADNIAJNN<TKey> : HHAPIDIPBKF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string PEJHICFDBHD(TKey DHCHBFGMFFD);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4EAEE70", Offset = "0x4EADA70", VA = "0x184EAEE70")]
	private static string CNHNLMCAGAF(TKey DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4EAEEB0", Offset = "0x4EADAB0", VA = "0x184EAEEB0", Slot = "4")]
	public override string LNIBKOKGCBA(LHKIACFOHBL<TKey> LFPPCCOIMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4EAEF60", Offset = "0x4EADB60", VA = "0x184EAEF60")]
	public string LNIBKOKGCBA(LHKIACFOHBL<TKey> LFPPCCOIMLK, [NotNull] PEJHICFDBHD FJMDDBOMJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string JGPNDDMGNDB(LHKIACFOHBL<TKey> LFPPCCOIMLK, [NotNull] PEJHICFDBHD FJMDDBOMJPM);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF0A0", Offset = "0x4EADCA0", VA = "0x184EAF0A0")]
	protected GMNADNIAJNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JKOEODKNAIO<TKey> : HHAPIDIPBKF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string OHPKMHGDFAP(TKey DHCHBFGMFFD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string BFBHANCPDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double NKKCCHFGNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool KBPEGMJEKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int LIMCNIDCCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> MODILDEHDEB;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x52E9CD0", Offset = "0x52E88D0", VA = "0x1852E9CD0")]
	private static string CNHNLMCAGAF(TKey DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x52EA7C0", Offset = "0x52E93C0", VA = "0x1852EA7C0")]
	public JKOEODKNAIO(string BFBHANCPDGA = "F2", double NKKCCHFGNHA = double.MaxValue, bool KBPEGMJEKEL = false, int LIMCNIDCCLO = int.MaxValue, [Optional] ISet<string> MODILDEHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x52EA500", Offset = "0x52E9100", VA = "0x1852EA500", Slot = "4")]
	public override Dictionary<string, string> LNIBKOKGCBA(LHKIACFOHBL<TKey> LFPPCCOIMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x52E9D10", Offset = "0x52E8910", VA = "0x1852E9D10")]
	private bool FIDCPFDDEOF(string ENKPJHKACGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x52E9F50", Offset = "0x52E8B50", VA = "0x1852E9F50")]
	public Dictionary<string, string> LNIBKOKGCBA(LHKIACFOHBL<TKey> LFPPCCOIMLK, OHPKMHGDFAP FJMDDBOMJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x52EA5B0", Offset = "0x52E91B0", VA = "0x1852EA5B0")]
	private string NFNBIIINMML(StringBuilder FIDLHGJJMHD, List<TKey> DADAEHIFBHD, OHPKMHGDFAP FJMDDBOMJPM, bool BDANFACBBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x52E9DF0", Offset = "0x52E89F0", VA = "0x1852E9DF0")]
	private static void GINNBNIIPPD(StringBuilder PKDPFOHAGMI, string GPLKLCJGOHB, bool NLMBBGAKKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MDMLLPACFIB<TKey> : GMNADNIAJNN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct KFFGOKJIHAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public PEJHICFDBHD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static MDMLLPACFIB<TKey> MFAGMJBMEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] CIOJELHHCFA;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x566A360", Offset = "0x5668F60", VA = "0x18566A360")]
	private MDMLLPACFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x56692B0", Offset = "0x5667EB0", VA = "0x1856692B0", Slot = "5")]
	protected override string JGPNDDMGNDB(LHKIACFOHBL<TKey> LFPPCCOIMLK, PEJHICFDBHD FJMDDBOMJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x566A140", Offset = "0x5668D40", VA = "0x18566A140")]
	[CompilerGenerated]
	internal static string PLLFCFIJIBB(string IMPLNBMCBOF, TKey DHCHBFGMFFD, KFFGOKJIHAC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class BJDGMHEIBKB : LHKIACFOHBL<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NHLCEAPJBAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<BJDGMHEIBKB, PEOHNMCPNIJ> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NHLCEAPJBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x80BD2C0", Offset = "0x80BBEC0", VA = "0x1880BD2C0")]
		internal void OHHCKEKOAMJ(LHKIACFOHBL<string> timer, PEOHNMCPNIJ log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x80BB6E0", Offset = "0x80BA2E0", VA = "0x1880BB6E0")]
	public BJDGMHEIBKB(PEOHNMCPNIJ GDLIBGFAMED, [Optional] string PCMGEFIDEON, [Optional] int? BOENOAMMAOO, [Optional] Stopwatch PFDBICJAICJ, [Optional] Action<string, LMBFKLFGKML, PEOHNMCPNIJ> JDIPGGIDMKE, [Optional] Action<string, LMBFKLFGKML, PEOHNMCPNIJ> OLAGFMGEIKF, [Optional] Action<BJDGMHEIBKB, PEOHNMCPNIJ> DMJLEFDAFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x80BB620", Offset = "0x80BA220", VA = "0x1880BB620")]
	private static Action<LHKIACFOHBL<string>, PEOHNMCPNIJ> IJBKNEDKCNG(Action<BJDGMHEIBKB, PEOHNMCPNIJ> HFBNHPDLHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class MIMAEBECGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class ALKNEFPOPHK : MIMAEBECGCB
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static MIMAEBECGCB MFAGMJBMEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x80BB3D0", Offset = "0x80B9FD0", VA = "0x1880BB3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float IFAOADEICNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x131E700", Offset = "0x131D300", VA = "0x18131E700", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x80BB4D0", Offset = "0x80BA0D0", VA = "0x1880BB4D0")]
		public ALKNEFPOPHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static MIMAEBECGCB JOIBAJGBPCD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static MIMAEBECGCB JOFMPALJJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x80BD090", Offset = "0x80BBC90", VA = "0x1880BD090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float IFAOADEICNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected MIMAEBECGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IGJFGOMAIOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool LBGGGNEDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface MNDBKMIALLI<T> : IGJFGOMAIOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> DFCEGPNNCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	AIDGEFHMIOM<T> DGMHNGMONBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NEFDGOBLMBG
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1E10", Offset = "0x3DC0A10", VA = "0x183DC1E10")]
	public static MNDBKMIALLI<TResource> GHGCCKFONFO<TResource, TId>(this OAINJCAAIFK<TId, TResource> HGDHKCAADKN, TId OIBGADINDDP, [Optional] Func<TId, CancellationToken, Task<TResource>>? PABEIKHNOBO) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BKPJMEMEDNN
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class DHCOJGCKLGB<T> : BLJCOKIDDNI<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> DFCEGPNNCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override AIDGEFHMIOM<T?> DGMHNGMONBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x44652E0", Offset = "0x4463EE0", VA = "0x1844652E0")]
		public DHCOJGCKLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "10")]
		protected override void CKPOLBKNEHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class ACJEKIMOCDP<T> : BLJCOKIDDNI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T FDKPMNPNOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? FEPFKFFLCJC;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> DFCEGPNNCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override AIDGEFHMIOM<T> DGMHNGMONBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x508F670", Offset = "0x508E270", VA = "0x18508F670")]
		public ACJEKIMOCDP(T MGGDDGHIKIG, Action<T>? HGEHGHPLMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x508F620", Offset = "0x508E220", VA = "0x18508F620", Slot = "10")]
		protected override void CKPOLBKNEHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class BLIKHDEKLPL<T> : BLJCOKIDDNI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> DFCEGPNNCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override AIDGEFHMIOM<T> DGMHNGMONBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x66EA900", Offset = "0x66E9500", VA = "0x1866EA900")]
		public BLIKHDEKLPL(Exception OOPJJOBMHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "10")]
		protected override void CKPOLBKNEHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class IJBGLEGLNMF<T> : BLJCOKIDDNI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct ILHFEMCLBBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<MNDBKMIALLI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<MNDBKMIALLI<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x50AB8B0", Offset = "0x50AA4B0", VA = "0x1850AB8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x50ABD80", Offset = "0x50AA980", VA = "0x1850ABD80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct MBCIKKJLANI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<MNDBKMIALLI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<MNDBKMIALLI<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x564AF60", Offset = "0x5649B60", VA = "0x18564AF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x564B180", Offset = "0x5649D80", VA = "0x18564B180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<MNDBKMIALLI<T>> LLONNPNLNMJ;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> DFCEGPNNCKI
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override AIDGEFHMIOM<T> DGMHNGMONBL
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5087470", Offset = "0x5086070", VA = "0x185087470")]
		public IJBGLEGLNMF(Task<MNDBKMIALLI<T>> MHGNKNMAFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5086F90", Offset = "0x5085B90", VA = "0x185086F90", Slot = "10")]
		protected override void CKPOLBKNEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x50871D0", Offset = "0x5085DD0", VA = "0x1850871D0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(IJBGLEGLNMF<>.ILHFEMCLBBO))]
		internal static Task<T> EAAJGPONONM(Task<MNDBKMIALLI<T>> MHGNKNMAFFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x50870F0", Offset = "0x5085CF0", VA = "0x1850870F0")]
		[AsyncStateMachine(typeof(IJBGLEGLNMF<>.MBCIKKJLANI))]
		[CompilerGenerated]
		internal static Task DBDINABOAEO(Task<MNDBKMIALLI<T>> MHGNKNMAFFC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class JHLKIBKLJMC<TIn, TOut> : BLJCOKIDDNI<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct LJIHBFOEPGG : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x5467440", Offset = "0x5466040", VA = "0x185467440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x50AE900", Offset = "0x50AD500", VA = "0x1850AE900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly MNDBKMIALLI<TIn> KJDEPFIGKCL;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> DFCEGPNNCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override AIDGEFHMIOM<TOut> DGMHNGMONBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x52E2EA0", Offset = "0x52E1AA0", VA = "0x1852E2EA0")]
		public JHLKIBKLJMC(MNDBKMIALLI<TIn> NBEPAOAHIMA, Func<TIn, TOut> AHHNLEKCDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x52E2B70", Offset = "0x52E1770", VA = "0x1852E2B70", Slot = "10")]
		protected override void CKPOLBKNEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x52E2D30", Offset = "0x52E1930", VA = "0x1852E2D30")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(JHLKIBKLJMC<, >.LJIHBFOEPGG))]
		internal static Task<TOut> FOMOIMFOIFD(Task<TIn> NKMINKAOLIH, Func<TIn, TOut> AHHNLEKCDAK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x39C5E00", Offset = "0x39C4A00", VA = "0x1839C5E00")]
	public static MNDBKMIALLI<T> LNCBONNLALO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x39C5E60", Offset = "0x39C4A60", VA = "0x1839C5E60")]
	public static MNDBKMIALLI<T> PCIOEJHCBCB<T>(T ABEFNIJCBBN, [Optional] Action<T>? HGEHGHPLMFM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x39C4240", Offset = "0x39C2E40", VA = "0x1839C4240")]
	public static MNDBKMIALLI<T> NEEAKEJOJHK<T>(Exception OOPJJOBMHKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x39C4240", Offset = "0x39C2E40", VA = "0x1839C4240")]
	public static MNDBKMIALLI<T> NHAFGBLELNC<T>(Task<MNDBKMIALLI<T>> MHGNKNMAFFC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3187C80", Offset = "0x3186880", VA = "0x183187C80")]
	public static MNDBKMIALLI<TOut> AJOIPBDPHOE<TOut, TIn>(MNDBKMIALLI<TIn> PHMFHDLJBOO, Func<TIn, TOut> AHHNLEKCDAK) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class BLJCOKIDDNI<T> : MNDBKMIALLI<T>, IGJFGOMAIOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string JEFMDBOKINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly GHCDGOPJPBJ LCNPDOFBKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool KBLIMDOOPKN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool LBGGGNEDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB27820", Offset = "0xB26420", VA = "0x180B27820", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> DFCEGPNNCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract AIDGEFHMIOM<T> DGMHNGMONBL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x66EAE10", Offset = "0x66E9A10", VA = "0x1866EAE10")]
	public BLJCOKIDDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x66EAB50", Offset = "0x66E9750", VA = "0x1866EAB50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CKPOLBKNEHH();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class PNFEEGNDFFE<TTask, T> : BLJCOKIDDNI<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class AHCLIDOJIEF
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
			public AHCLIDOJIEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4423730", Offset = "0x4422330", VA = "0x184423730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x44239F0", Offset = "0x44225F0", VA = "0x1844239F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public PNFEEGNDFFE<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AHCLIDOJIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5096840", Offset = "0x5095440", VA = "0x185096840")]
		[AsyncStateMachine(typeof(PNFEEGNDFFE<, >.AHCLIDOJIEF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> HMIAFLPKJDK(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> MHGNKNMAFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource OFBLADCGCLF;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> DFCEGPNNCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override AIDGEFHMIOM<T> DGMHNGMONBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5A19D40", Offset = "0x5A18940", VA = "0x185A19D40")]
	protected PNFEEGNDFFE(TTask MHGNKNMAFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5A19CF0", Offset = "0x5A188F0", VA = "0x185A19CF0", Slot = "10")]
	protected override void CKPOLBKNEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T GPHJGDFDGBP(TTask CPPAFNIPBCD);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void NPOHFGHHAJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FNJAOJOOKFE<T> : BLJCOKIDDNI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly ODNHGKKANOM<Task<T>> ALFJIFFLMDO;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> DFCEGPNNCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F270", Offset = "0x4D7DE70", VA = "0x184D7F270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override AIDGEFHMIOM<T> DGMHNGMONBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F2B0", Offset = "0x4D7DEB0", VA = "0x184D7F2B0")]
	public FNJAOJOOKFE(ODNHGKKANOM<Task<T>> FMBFGFABBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F250", Offset = "0x4D7DE50", VA = "0x184D7F250", Slot = "10")]
	protected override void CKPOLBKNEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class PKPIGAKPHHI
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName NHFEEGEGEAL;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> JCHGPHLFGME;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x80BD9A0", Offset = "0x80BC5A0", VA = "0x1880BD9A0")]
	public static int COHNMODCAOL(this LKPCPIPPIDO OELCAIONKMC, IncrementalHash FNNEEIFKEML, byte[] ANOBCDIGNDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x80BDD40", Offset = "0x80BC940", VA = "0x1880BDD40")]
	public static bool HJKPNEKJMKE([CanBeNull] this LKPCPIPPIDO OELCAIONKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x80BDA30", Offset = "0x80BC630", VA = "0x1880BDA30")]
	public static bool HJKPNEKJMKE([CanBeNull] this LKPCPIPPIDO OELCAIONKMC, [Out] string PDIIGKEPNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x80BDDA0", Offset = "0x80BC9A0", VA = "0x1880BDDA0")]
	public static bool HJKPNEKJMKE([CanBeNull] this LKPCPIPPIDO OELCAIONKMC, IncrementalHash FNNEEIFKEML, byte[] ANOBCDIGNDN, [Out] string PDIIGKEPNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x80BD910", Offset = "0x80BC510", VA = "0x1880BD910")]
	private static bool BLMEKGNLFLF(byte[] FIPDLIAIJMF, Span<byte> KDFMEPJKIAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class GEMBBMLKMDC
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x80BBA80", Offset = "0x80BA680", VA = "0x1880BBA80")]
	public static int GPGIILAMPIB(HashAlgorithmName LNCPFFGCMED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3C43790", Offset = "0x3C42390", VA = "0x183C43790")]
	public static int COHNMODCAOL<T>(this T IOINLLOKHGG, byte[] BNGJDNCKPMN, IncrementalHash FNNEEIFKEML, byte[] CJNNOMKHKHI) where T : OPFAJFCMNPJ
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface OPFAJFCMNPJ
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FNNEEIFKEML);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface LKPCPIPPIDO : OPFAJFCMNPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] HDGDCHNIAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] EHGKAKFBJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class MADEAELNJFF
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool CKFJEEDKELO;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> NOLIMMOJHIJ;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> IBHJHJELFOF;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding GFHOAGLJPAA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> DPGFFFKMEHC;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3D42A60", Offset = "0x3D41660", VA = "0x183D42A60")]
	public static void MMLCAHKJJBJ<T>(this IncrementalHash DMIEIICADIH, [CanBeNull] T GCOJJLDOHCO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3D41850", Offset = "0x3D40450", VA = "0x183D41850")]
	public static void DGOFBOLABII<T>(this IncrementalHash DMIEIICADIH, [CanBeNull] T IOINLLOKHGG) where T : OPFAJFCMNPJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3D42540", Offset = "0x3D41140", VA = "0x183D42540")]
	public static void JPODNEDFJLD<T>(this IncrementalHash DMIEIICADIH, [CanBeNull] IList<T> MPKPPKBDPGE) where T : OPFAJFCMNPJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x80BCD00", Offset = "0x80BB900", VA = "0x1880BCD00")]
	private static bool OBNAHFICFEJ([CanBeNull] OPFAJFCMNPJ IOINLLOKHGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x80BC590", Offset = "0x80BB190", VA = "0x1880BC590")]
	public static void JILHLNNIKPO(this IncrementalHash FNNEEIFKEML, string? KENHPJJEDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x80BBEB0", Offset = "0x80BAAB0", VA = "0x1880BBEB0")]
	public static void AJMCKLEDBDK(this IncrementalHash FNNEEIFKEML, long GCOGDCGECOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x80BC360", Offset = "0x80BAF60", VA = "0x1880BC360")]
	public static void HAGOOHNOKEF(this IncrementalHash FNNEEIFKEML, int BLOKNPPLFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x80BC080", Offset = "0x80BAC80", VA = "0x1880BC080")]
	public static void EBIFOACFEOA(this IncrementalHash FNNEEIFKEML, short CKPKMKDPLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x80BC250", Offset = "0x80BAE50", VA = "0x1880BC250")]
	public static void GLNCKLDNHEK(this IncrementalHash FNNEEIFKEML, byte PIMMDAKKLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x80BCB30", Offset = "0x80BB730", VA = "0x1880BCB30")]
	public static void MMPCMFFCNOH(this IncrementalHash FNNEEIFKEML, bool NMCFBBJHNIH, bool KECHGNCCEML = false, bool EAJNECNMJMN = false, bool OJFHHJNBALA = false, bool KPNLMGNBKKE = false, bool OCDGBBKLDLM = false, bool GMJNENMAFEH = false, bool MNICKCGHHOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3D418E0", Offset = "0x3D404E0", VA = "0x183D418E0")]
	public static void FLFGMJMEEEP<T>(this IncrementalHash FNNEEIFKEML, T IILFEKLIFDP) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x80BC530", Offset = "0x80BB130", VA = "0x1880BC530")]
	public static void HKPNKBDKIHI(this IncrementalHash FNNEEIFKEML, float BBCPIEDBAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x80BC9A0", Offset = "0x80BB5A0", VA = "0x1880BC9A0")]
	public static void KAAOGFCCPLI(this IncrementalHash FNNEEIFKEML, ulong IPNPLMEMJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x80BCCA0", Offset = "0x80BB8A0", VA = "0x1880BCCA0")]
	public static void NEENHFKEMHH(this IncrementalHash FNNEEIFKEML, uint AACMBOPJPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x80BCD90", Offset = "0x80BB990", VA = "0x1880BCD90")]
	public static void PGKLDDLCJHD(this IncrementalHash FNNEEIFKEML, ushort APPMIKCPPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x80BCA00", Offset = "0x80BB600", VA = "0x1880BCA00")]
	public static void MMBHFCCAKHC(this IncrementalHash FNNEEIFKEML, Vector3 HCPDNANKJML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class GCMEHPJKOJP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x80BBA20", Offset = "0x80BA620", VA = "0x1880BBA20")]
	public GCMEHPJKOJP(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class BIGMFMBMHDM
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void OMCJNPMKIHO(ushort JLFLMMEEEDM, ushort FPKFFMKGCPN, ushort JMEPHINEAMI, ushort BPDOLDNGDIC);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void NJKIHEKLEML(ushort CFPADDFIECD, ushort CHGGALJGJPO);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void EJFAHFCPHHG();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort BLDADLHIIPG = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected BIGMFMBMHDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class PNOFHJIGJNG<T> : BIGMFMBMHDM where T : PNOFHJIGJNG<T>.EKNJCKHIGBL
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface EKNJCKHIGBL
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		NJKIHEKLEML OCBPBFMGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		NJKIHEKLEML HNMEHOHJLLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		EJFAHFCPHHG JKNODKCAFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> GIBABHCNLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private EJFAHFCPHHG LNDPPOELIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private EJFAHFCPHHG IMOMKNPDPBG;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool LOAJELOACKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA61310", Offset = "0xA5FF10", VA = "0x180A61310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort KJIPBDDEBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x11F6F90", Offset = "0x11F5B90", VA = "0x1811F6F90")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x11F7350", Offset = "0x11F5F50", VA = "0x1811F7350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort DIIMEGDGBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C020", Offset = "0x5A1AC20", VA = "0x185A1C020")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C9F0", Offset = "0x5A1B5F0", VA = "0x185A1C9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort BPONFKNMKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xEFF320", Offset = "0xEFDF20", VA = "0x180EFF320")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xEFF3E0", Offset = "0xEFDFE0", VA = "0x180EFF3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort FBHCPHJFLCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C010", Offset = "0x5A1AC10", VA = "0x185A1C010")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5A1CBB0", Offset = "0x5A1B7B0", VA = "0x185A1CBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool OOIFMJPJHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x11F6FA0", Offset = "0x11F5BA0", VA = "0x1811F6FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool KNMBJNPONCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xFF3DF0", Offset = "0xFF29F0", VA = "0x180FF3DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OMCJNPMKIHO EBPCNLOEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C950", Offset = "0x5A1B550", VA = "0x185A1C950")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5A1CAA0", Offset = "0x5A1B6A0", VA = "0x185A1CAA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CD70", Offset = "0x5A1B970", VA = "0x185A1CD70")]
	private T PNFHBLGEAIO(ushort CIKOAJKAFFI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CA10", Offset = "0x5A1B610", VA = "0x185A1CA10")]
	private T JLBKNKIPAFM(ushort CIKOAJKAFFI, ushort MCFAKHFLOJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CBC0", Offset = "0x5A1B7C0", VA = "0x185A1CBC0")]
	protected T LOIBKBALMDA(uint EGKOAAJKFEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CE00", Offset = "0x5A1BA00", VA = "0x185A1CE00")]
	protected PNOFHJIGJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CD00", Offset = "0x5A1B900", VA = "0x185A1CD00")]
	public void MHBFKMJKNMK(ushort HCIJNGOKDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CD20", Offset = "0x5A1B920", VA = "0x185A1CD20")]
	public void MHBFKMJKNMK(ushort HCIJNGOKDLF, ushort LJIDEIKJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CC40", Offset = "0x5A1B840", VA = "0x185A1CC40", Slot = "4")]
	protected virtual void MHBFKMJKNMK(uint EDPBKJKOELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C260", Offset = "0x5A1AE60", VA = "0x185A1C260")]
	protected void ICAICOICAAM(uint EDPBKJKOELG, uint EMAFOOODCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CB40", Offset = "0x5A1B740", VA = "0x185A1CB40")]
	protected void KFHKBJGOPML(ushort CIKOAJKAFFI, ushort MCFAKHFLOJN, T EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CC10", Offset = "0x5A1B810", VA = "0x185A1CC10")]
	private void MGOKBBJMANP(uint EGKOAAJKFEN, T EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C030", Offset = "0x5A1AC30", VA = "0x185A1C030")]
	protected void EDIKFMNFKEM(float EOLAIOLLEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CA00", Offset = "0x5A1B600", VA = "0x185A1CA00")]
	protected uint JAKJLOLKFMM(ushort CIKOAJKAFFI, ushort MCFAKHFLOJN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C940", Offset = "0x5A1B540", VA = "0x185A1C940")]
	protected ushort ICFDAALNFHH(uint ACLGHANEAMF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CC00", Offset = "0x5A1B800", VA = "0x185A1CC00")]
	protected ushort MCICLNJPHNE(uint ACLGHANEAMF)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class INHOIIOPCHE : PNOFHJIGJNG<INHOIIOPCHE.GALMAFLCMHE>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class GALMAFLCMHE : EKNJCKHIGBL
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NJKIHEKLEML OCBPBFMGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public NJKIHEKLEML HNMEHOHJLLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public EJFAHFCPHHG JKNODKCAFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GALMAFLCMHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x80BBC20", Offset = "0x80BA820", VA = "0x1880BBC20")]
	public void PIJENNFAAFM(ushort MOOJHLLIAFF, NJKIHEKLEML BOAMLJADPEM, NJKIHEKLEML JGBCIKNPENF, EJFAHFCPHHG HPCFCDEMPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x80BBD00", Offset = "0x80BA900", VA = "0x1880BBD00")]
	public void PIJENNFAAFM(ushort CIKOAJKAFFI, ushort MCFAKHFLOJN, NJKIHEKLEML BOAMLJADPEM, NJKIHEKLEML JGBCIKNPENF, EJFAHFCPHHG HPCFCDEMPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x80BBBD0", Offset = "0x80BA7D0", VA = "0x1880BBBD0")]
	public void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x80BB5E0", Offset = "0x80BA1E0", VA = "0x1880BB5E0")]
	protected INHOIIOPCHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BHILPPFHJPD : INHOIIOPCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool JBJJEMCJKGN;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD297E0", Offset = "0xD283E0", VA = "0x180D297E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xDDA030", Offset = "0xDD8C30", VA = "0x180DDA030")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x80BB520", Offset = "0x80BA120", VA = "0x1880BB520")]
	public void BFHPBJMBKJO(ushort CONHIOAIMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x80BB580", Offset = "0x80BA180", VA = "0x1880BB580")]
	public void BFHPBJMBKJO(ushort CONHIOAIMNB, ushort JKLNMBMMAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x80BB5E0", Offset = "0x80BA1E0", VA = "0x1880BB5E0")]
	public BHILPPFHJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class FFLBLMNLKLG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class GDNEDMIFAKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode JBDFDFABHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode IEPNOLIPIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public EIBKNJLMJDC JAOGNEOIMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<EIBKNJLMJDC> MLHODJIALFF;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GDNEDMIFAKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct EIBKNJLMJDC : IComparable<EIBKNJLMJDC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int PBEMDBEINCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant HJGOFLBIJOM;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1876FA0", Offset = "0x1875BA0", VA = "0x181876FA0")]
		public EIBKNJLMJDC(int PBEMDBEINCB, TClaimant HJGOFLBIJOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x48D8460", Offset = "0x48D7060", VA = "0x1848D8460")]
		public bool HGNNAEILDGO([In] EIBKNJLMJDC IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x48D8450", Offset = "0x48D7050", VA = "0x1848D8450")]
		public bool DEABCOIFMLA([In] EIBKNJLMJDC IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x48D8440", Offset = "0x48D7040", VA = "0x1848D8440", Slot = "4")]
		public int CompareTo(EIBKNJLMJDC IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x48D84C0", Offset = "0x48D70C0", VA = "0x1848D84C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum GHPDCEJKBLD
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class POFMHHACIAH : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public FFLBLMNLKLG<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public POFMHHACIAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D560", Offset = "0x5A1C160", VA = "0x185A1D560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D720", Offset = "0x5A1C320", VA = "0x185A1D720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D640", Offset = "0x5A1C240", VA = "0x185A1D640", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4DF45A0", Offset = "0x4DF31A0", VA = "0x184DF45A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly HKDOFLHGMIJ<GDNEDMIFAKO> OHPHMGFJBMJ;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly HKDOFLHGMIJ<List<EIBKNJLMJDC>> AAPDHHFELEC;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int GGOBGGOJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> HLAKENFDODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, GDNEDMIFAKO> GFDDDBMLOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private GHPDCEJKBLD CEBNHJNKAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool BNHFKKOIPKI;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode JLPLCLPMPFD(TNode PBBEMEGKFPO);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void OMJNCAIMAAJ(TNode PBBEMEGKFPO, TClaimant CKIOHOMMDAE, TClaimant OOKBDGAKMNC);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D71300", Offset = "0x4D6FF00", VA = "0x184D71300")]
	public FFLBLMNLKLG(GHPDCEJKBLD CEBNHJNKAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D70D30", Offset = "0x4D6F930", VA = "0x184D70D30")]
	public void MAKAGHHEDKM(TNode PBBEMEGKFPO, TNode AHLLNEDBFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D70560", Offset = "0x4D6F160", VA = "0x184D70560")]
	public void HIPPDPIAKDO(TClaimant HJGOFLBIJOM, TNode BPJBCIAGJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D702A0", Offset = "0x4D6EEA0", VA = "0x184D702A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D704C0", Offset = "0x4D6F0C0", VA = "0x184D704C0")]
	private void EJIPCDONAEJ(TClaimant HJGOFLBIJOM, TNode OPAIPGPCKPM, TNode BPJBCIAGJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D70450", Offset = "0x4D6F050", VA = "0x184D70450")]
	private int EFHHPFDAIJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D70940", Offset = "0x4D6F540", VA = "0x184D70940")]
	private void INDKIFHLFPL(TClaimant HJGOFLBIJOM, TNode CLJLIGAFHLB, TNode PMJLFMNJFLB, int KBPCPJHMAPE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D6FDF0", Offset = "0x4D6E9F0", VA = "0x184D6FDF0")]
	private void DCIKJBIKDPO(EIBKNJLMJDC LJNBIMLCHGB, GDNEDMIFAKO GLMMAMOKOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4D70680", Offset = "0x4D6F280", VA = "0x184D70680")]
	private void HLCDODJEFGH(TClaimant HJGOFLBIJOM, TNode CLJLIGAFHLB, TNode PMJLFMNJFLB, int KBPCPJHMAPE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4D70F20", Offset = "0x4D6FB20", VA = "0x184D70F20")]
	private void MIJLNLMGOJD(EIBKNJLMJDC LJNBIMLCHGB, TNode PBBEMEGKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D6FBB0", Offset = "0x4D6E7B0", VA = "0x184D6FBB0")]
	private void AFADNBKJKML(EIBKNJLMJDC LJNBIMLCHGB, GDNEDMIFAKO GLMMAMOKOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D71030", Offset = "0x4D6FC30", VA = "0x184D71030")]
	private void PHMPODBBHIM(GDNEDMIFAKO GLMMAMOKOAD, bool FLGMIAKHHJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D6FE70", Offset = "0x4D6EA70", VA = "0x184D6FE70")]
	private void DEFOAMBMAKE(GDNEDMIFAKO GLMMAMOKOAD, TNode AHLLNEDBFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D70C60", Offset = "0x4D6F860", VA = "0x184D70C60")]
	[IteratorStateMachine(typeof(FFLBLMNLKLG<, >.POFMHHACIAH))]
	private IEnumerable<TNode> LPJLDNINANJ(TNode CLJLIGAFHLB, TNode PMJLFMNJFLB, bool MNEKEFHJNFH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D701C0", Offset = "0x4D6EDC0", VA = "0x184D701C0")]
	private GDNEDMIFAKO DPGBIBAPEJL(TNode PBBEMEGKFPO, TNode IEPNOLIPIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D70DC0", Offset = "0x4D6F9C0", VA = "0x184D70DC0")]
	private GDNEDMIFAKO MHFJJJPIHLJ(TNode PBBEMEGKFPO, TNode IEPNOLIPIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D6FC90", Offset = "0x4D6E890", VA = "0x184D6FC90")]
	private void CHIKPKHDHLL(GDNEDMIFAKO GLMMAMOKOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DBOLDPCBHFA<T> : IEnumerable<DBOLDPCBHFA<T>.ODMPDFNFPMM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct ODMPDFNFPMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T BKMPCFIAHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int LCCBBMBENOH;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class FJJKCNJJPJL : IEnumerator<ODMPDFNFPMM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private DBOLDPCBHFA<T> LDOBEDEHEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int LCCBBMBENOH;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4909580", Offset = "0x4908180", VA = "0x184909580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public ODMPDFNFPMM ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4D7A000", Offset = "0x4D78C00", VA = "0x184D7A000", Slot = "4")]
			get
			{
				return default(ODMPDFNFPMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4D79F10", Offset = "0x4D78B10", VA = "0x184D79F10")]
		public FJJKCNJJPJL(DBOLDPCBHFA<T> LDOBEDEHEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4D79E10", Offset = "0x4D78A10", VA = "0x184D79E10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x496C210", Offset = "0x496AE10", VA = "0x18496C210", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x128AEC0", Offset = "0x1289AC0", VA = "0x18128AEC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct KDEFOJHGLGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool CNOBOPDPAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T BKMPCFIAHIG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int CCGEDJAIKCJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> OFFOJMBEFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private KDEFOJHGLGA[] PBOPLMJKLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int GEDGKNEBCCK;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int JHLLCENFEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B60", Offset = "0xABF760", VA = "0x180AC0B60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x10131E0", Offset = "0x1011DE0", VA = "0x1810131E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x443AEA0", Offset = "0x4439AA0", VA = "0x18443AEA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4456D30", Offset = "0x4455930", VA = "0x184456D30")]
	public DBOLDPCBHFA(int FJNGONEOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x44571C0", Offset = "0x4455DC0", VA = "0x1844571C0")]
	public DBOLDPCBHFA(ODMPDFNFPMM[] KIIFKMLKAEM, bool CFHPIHMFAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4456AD0", Offset = "0x44556D0", VA = "0x184456AD0")]
	public int HOOBMBHPFAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4456250", Offset = "0x4454E50", VA = "0x184456250")]
	private int AFHPFCHPHFJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4456470", Offset = "0x4455070", VA = "0x184456470", Slot = "6")]
	protected virtual uint ALOIKJDKALK(uint FNNEEIFKEML, T BKMPCFIAHIG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4456B90", Offset = "0x4455790", VA = "0x184456B90")]
	public bool KIPKJKHLNOJ(T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4456C40", Offset = "0x4455840", VA = "0x184456C40")]
	public int NDPBAPKILJE(T BKMPCFIAHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4456A60", Offset = "0x4455660", VA = "0x184456A60")]
	public T CLFPKKLNFPN(int LCCBBMBENOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x44566D0", Offset = "0x44552D0", VA = "0x1844566D0")]
	public bool BFMHMFJPMDI(T BKMPCFIAHIG, bool CGCOGGAMBLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x44564D0", Offset = "0x44550D0", VA = "0x1844564D0")]
	public bool BFMHMFJPMDI(T BKMPCFIAHIG, int LCCBBMBENOH, bool CGCOGGAMBLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x44569C0", Offset = "0x44555C0", VA = "0x1844569C0")]
	private int BNFFOLHHMLK(int FAHOKHGHPIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4456CB0", Offset = "0x44558B0", VA = "0x184456CB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4456CB0", Offset = "0x44558B0", VA = "0x184456CB0", Slot = "4")]
	private IEnumerator<ODMPDFNFPMM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class HKDOFLHGMIJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> KBEGPPOKLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> KOBBMJHJBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int MFFCMJLPONE;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E9D0", Offset = "0x4F9D5D0", VA = "0x184F9E9D0")]
	public static HKDOFLHGMIJ<T> IJDDEEKHCGG(int FJNGONEOHID = 0, int MFFCMJLPONE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EAB0", Offset = "0x4F9D6B0", VA = "0x184F9EAB0")]
	public static HKDOFLHGMIJ<T> KOGOOJIFKCE(int FJNGONEOHID = 0, int MFFCMJLPONE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EFD0", Offset = "0x4F9DBD0", VA = "0x184F9EFD0")]
	public HKDOFLHGMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F000", Offset = "0x4F9DC00", VA = "0x184F9F000")]
	public HKDOFLHGMIJ(int FJNGONEOHID, int MFFCMJLPONE = int.MaxValue, bool JIICGMENJIJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EE50", Offset = "0x4F9DA50", VA = "0x184F9EE50")]
	public T PKHHFIDGGFC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4F9ED80", Offset = "0x4F9D980", VA = "0x184F9ED80")]
	public void NCHKMOJJHLK(T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E900", Offset = "0x4F9D500", VA = "0x184F9E900")]
	private void HGGAHPGGOBN(T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E7A0", Offset = "0x4F9D3A0", VA = "0x184F9E7A0")]
	private void DCLMGNKHAGG(T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E7C0", Offset = "0x4F9D3C0", VA = "0x184F9E7C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EB90", Offset = "0x4F9D790", VA = "0x184F9EB90")]
	private void LAIGNGPMCAP(IEnumerable<T> OKFGGFMLPHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MMOEHDDLDEB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> ELIABFCDDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T PIDBOEICMID;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T CPEFEKHCFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x56A4720", Offset = "0x56A3320", VA = "0x1856A4720")]
	public bool NFFELAKAFBO(T BKMPCFIAHIG, int PBEMDBEINCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x49017A0", Offset = "0x49003A0", VA = "0x1849017A0")]
	public bool HJKJEJAICJB(int PBEMDBEINCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x56A4500", Offset = "0x56A3100", VA = "0x1856A4500")]
	public T CAMPDNLGPAN(int KIBIIJLJAMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x56A41D0", Offset = "0x56A2DD0", VA = "0x1856A41D0")]
	private bool BHPEICAJPNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x56A46E0", Offset = "0x56A32E0", VA = "0x1856A46E0")]
	public bool GLNNPKODOFD(int PBEMDBEINCB, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4901FC0", Offset = "0x4900BC0", VA = "0x184901FC0")]
	public MMOEHDDLDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class OBLHHKEGGFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct LLHOIAHNCBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T AHLMJDKCEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int LDMAJBAGNJL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<LLHOIAHNCBH> JMHKPAOIEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T KLCHKHJPMMC;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x443AEA0", Offset = "0x4439AA0", VA = "0x18443AEA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x584AE00", Offset = "0x5849A00", VA = "0x18584AE00")]
	public bool KDPIOFHPCJJ(T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x584B330", Offset = "0x5849F30", VA = "0x18584B330")]
	public void NDGLNAHKHEG(T BKMPCFIAHIG, int PBEMDBEINCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x584A930", Offset = "0x5849530", VA = "0x18584A930")]
	public bool ENKPLOICKCM(T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x584AC10", Offset = "0x5849810", VA = "0x18584AC10")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x584B440", Offset = "0x584A040", VA = "0x18584B440")]
	public T PDNLKDFFHAC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x584B040", Offset = "0x5849C40", VA = "0x18584B040")]
	protected void LMHEJACACKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x584B550", Offset = "0x584A150", VA = "0x18584B550")]
	public OBLHHKEGGFG()
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
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x80BE370", Offset = "0x80BCF70", VA = "0x1880BE370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x80BE640", Offset = "0x80BD240", VA = "0x1880BE640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x80BE550", Offset = "0x80BD150", VA = "0x1880BE550")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x80BE2C0", Offset = "0x80BCEC0", VA = "0x1880BE2C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x80BE590", Offset = "0x80BD190", VA = "0x1880BE590")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x80BE4A0", Offset = "0x80BD0A0", VA = "0x1880BE4A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x80BE230", Offset = "0x80BCE30", VA = "0x1880BE230")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BF84F0", Offset = "0x5BF70F0", VA = "0x185BF84F0", Slot = "4")]
		public virtual T FCILBAJDDKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface EGDDMCACOBE
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache HCDOIMDPPPF
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
		public struct PMPCPBNNOJK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> ADEANPNALNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool ALMLJBNBDND;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x19E6500", Offset = "0x19E5100", VA = "0x1819E6500")]
			public PMPCPBNNOJK(List<Component> ADEANPNALNF, bool ALMLJBNBDND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5A16A50", Offset = "0x5A15650", VA = "0x185A16A50")]
			public CDFDAHAIGCF<T> MIEHOANGBJG()
			{
				return default(CDFDAHAIGCF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x5A16AB0", Offset = "0x5A156B0", VA = "0x185A16AB0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x5A16AB0", Offset = "0x5A156B0", VA = "0x185A16AB0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct CDFDAHAIGCF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> ADEANPNALNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool ALMLJBNBDND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int LCCBBMBENOH;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T ALGELFNIHOP
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x6A6DFD0", Offset = "0x6A6CBD0", VA = "0x186A6DFD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x6A6DF60", Offset = "0x6A6CB60", VA = "0x186A6DF60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x6A6DFA0", Offset = "0x6A6CBA0", VA = "0x186A6DFA0")]
			public CDFDAHAIGCF(List<Component> ADEANPNALNF, bool ALMLJBNBDND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x6A6DEA0", Offset = "0x6A6CAA0", VA = "0x186A6DEA0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x6A6DEB0", Offset = "0x6A6CAB0", VA = "0x186A6DEB0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x495A930", Offset = "0x4959530", VA = "0x18495A930", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x80C0070", Offset = "0x80BEC70", VA = "0x1880C0070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x80BF9E0", Offset = "0x80BE5E0", VA = "0x1880BF9E0")]
		private void BFHPBJMBKJO(GameObject JDCKHFIIKIH, bool GPAPPOJDLEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x80BF950", Offset = "0x80BE550", VA = "0x1880BF950")]
		public static void BFHPBJMBKJO(GameObject JDCKHFIIKIH, ToolHierarchyCache HGDHKCAADKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x80BFBD0", Offset = "0x80BE7D0", VA = "0x1880BFBD0")]
		public void GADIFCKDOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3FCF7F0", Offset = "0x3FCE3F0", VA = "0x183FCF7F0")]
		public void DCDJADFJGDG<T>(Action<T> KLIEOOEGDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3FCFAD0", Offset = "0x3FCE6D0", VA = "0x183FCFAD0")]
		public T POFEGHJEPEH<T>(bool ALMLJBNBDND = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3FCFA10", Offset = "0x3FCE610", VA = "0x183FCFA10")]
		public PMPCPBNNOJK<T> MNDNMEONHFN<T>(bool ALMLJBNBDND = false) where T : class
		{
			return default(PMPCPBNNOJK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x80BFC50", Offset = "0x80BE850", VA = "0x1880BFC50")]
		public List<Component> ILBEALDELOD(Type MDCDODCGNEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x80BFB50", Offset = "0x80BE750", VA = "0x1880BFB50", Slot = "4")]
		public bool Equals(ToolHierarchyCache LGCEHLADNJC, ToolHierarchyCache LFHMHCKODDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x80BFBE0", Offset = "0x80BE7E0", VA = "0x1880BFBE0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KOJLNGLNBMH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class LIPOBPPCKNA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int FJNGONEOHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int GHCOLDBIOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> GIPHBDCKJDN;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F270", Offset = "0x4D7DE70", VA = "0x184D7F270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T LELGPBLLFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x54646F0", Offset = "0x54632F0", VA = "0x1854646F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T HELGGNGHNCL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5464450", Offset = "0x5463050", VA = "0x185464450")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T BIIOHGDBHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x54645C0", Offset = "0x54631C0", VA = "0x1854645C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5464B40", Offset = "0x5463740", VA = "0x185464B40")]
	public LIPOBPPCKNA(int FJNGONEOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5464910", Offset = "0x5463510", VA = "0x185464910")]
	public void NDGLNAHKHEG(T NALBMAMILBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5464530", Offset = "0x5463130", VA = "0x185464530")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5464840", Offset = "0x5463440", VA = "0x185464840")]
	public void LCEHIEOOMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5464AF0", Offset = "0x54636F0", VA = "0x185464AF0")]
	public void PLOFPPBHCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5464900", Offset = "0x5463500", VA = "0x185464900")]
	public void NAJPEKGEOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x54647C0", Offset = "0x54633C0", VA = "0x1854647C0")]
	public List<T> KGMGPJNLNAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class ENGNEPIGOEM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct LBKLHPHEAFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int LDMAJBAGNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T AHLMJDKCEID;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, LBKLHPHEAFB> ELIABFCDDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> NOMHPLBLMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T PIDBOEICMID;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T CPEFEKHCFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE4A620", Offset = "0xE49220", VA = "0x180E4A620", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x48EEA10", Offset = "0x48ED610", VA = "0x1848EEA10", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool IJLGIOHKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x48EB850", Offset = "0x48EA450", VA = "0x1848EB850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object IBNGGMINHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x48EF400", Offset = "0x48EE000", VA = "0x1848EF400")]
	public bool NFFELAKAFBO(T BKMPCFIAHIG, object DANCOEFIHDF, int PBEMDBEINCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x48EE990", Offset = "0x48ED590", VA = "0x1848EE990")]
	public bool HJKJEJAICJB(object DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x48EE670", Offset = "0x48ED270", VA = "0x1848EE670")]
	public bool GLNNPKODOFD(object DANCOEFIHDF, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x48EE960", Offset = "0x48ED560", VA = "0x1848EE960")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x48ED8D0", Offset = "0x48EC4D0", VA = "0x1848ED8D0")]
	private bool BHPEICAJPNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x48EF4B0", Offset = "0x48EE0B0", VA = "0x1848EF4B0")]
	public ENGNEPIGOEM()
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
