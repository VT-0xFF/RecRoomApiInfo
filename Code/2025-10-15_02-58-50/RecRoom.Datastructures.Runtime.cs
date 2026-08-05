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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84423F0", Offset = "0x84411F0", VA = "0x1884423F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CompactArrayDrawerAttribute : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x247F480", Offset = "0x247E280", VA = "0x18247F480")]
	public CompactArrayDrawerAttribute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, TSFGMBDUIRU, VHIUCTLOYWO, ISerializationCallbackReceiver
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
	public byte[] CWBNHGBKESU
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] JMPCQOADGBY
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object KAPAMLNTHTX
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash hash);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
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
	private float XKEMOXCGPDM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float RGIIQGMRBVV;

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
		[Cpp2IlInjected.Address(RVA = "0x84437F0", Offset = "0x84425F0", VA = "0x1884437F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84437B0", Offset = "0x84425B0", VA = "0x1884437B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8443830", Offset = "0x8442630", VA = "0x188443830")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8443950", Offset = "0x8442750", VA = "0x188443950")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84438B0", Offset = "0x84426B0", VA = "0x1884438B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAF9180", Offset = "0xAF7F80", VA = "0x180AF9180")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAFFA60", Offset = "0xAFE860", VA = "0x180AFFA60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8443790", Offset = "0x8442590", VA = "0x188443790")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF240A0", Offset = "0xF22EA0", VA = "0x180F240A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8443370", Offset = "0x8442170", VA = "0x188443370")]
	public void CopyBounds(SavedExtents other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84436F0", Offset = "0x84424F0", VA = "0x1884436F0")]
	public void SetLocalSpaceBounds(Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1753600", Offset = "0x1752400", VA = "0x181753600")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8443620", Offset = "0x8442420", VA = "0x188443620")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8442B20", Offset = "0x8441920", VA = "0x188442B20")]
	private void ANJNDACSAFR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84433A0", Offset = "0x84421A0", VA = "0x1884433A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8442D20", Offset = "0x8441B20", VA = "0x188442D20")]
	public static void CalculateLocalBoundsFor(GameObject gameObject, [Out] Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8443630", Offset = "0x8442430", VA = "0x188443630")]
	private static void QCERSPDPMII(Bounds a, Color b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8443710", Offset = "0x8442510", VA = "0x188443710")]
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
		[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAAA950", Offset = "0xAA9750", VA = "0x180AAA950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C32EE0", Offset = "0x1C31CE0", VA = "0x181C32EE0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x601F1A0", Offset = "0x601DFA0", VA = "0x18601F1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
	public virtual void HCUMWEQHLXX()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
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
	[Cpp2IlInjected.Address(RVA = "0x601CE00", Offset = "0x601BC00", VA = "0x18601CE00", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x601BCF0", Offset = "0x601AAF0", VA = "0x18601BCF0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x601D140", Offset = "0x601BF40", VA = "0x18601D140")]
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
	private sealed class LXCOCJKLUFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> ORCDTGIFVII;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public LXCOCJKLUFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5490850", Offset = "0x548F650", VA = "0x185490850")]
		internal int BLSBYHLUIXH(TKeyVal a, TKeyVal b)
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
	private readonly Dictionary<TKey, TVal> VBZRMGHZYJP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x496CC80", Offset = "0x496BA80", VA = "0x18496CC80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x496CCF0", Offset = "0x496BAF0", VA = "0x18496CCF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x496CA20", Offset = "0x496B820", VA = "0x18496CA20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey key]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x496CAC0", Offset = "0x496B8C0", VA = "0x18496CAC0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> PWSUZXDOPRI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x496C6D0", Offset = "0x496B4D0", VA = "0x18496C6D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x496C1F0", Offset = "0x496AFF0", VA = "0x18496C1F0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x496B600", Offset = "0x496A400", VA = "0x18496B600", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x496B540", Offset = "0x496A340", VA = "0x18496B540", Slot = "14")]
	protected virtual string HKCKYAPPHMI(TKeyVal a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x496B350", Offset = "0x496A150", VA = "0x18496B350", Slot = "4")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x496C370", Offset = "0x496B170", VA = "0x18496C370", Slot = "5")]
	public bool TryGetValue(TKey key, [Out] TVal value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x496B420", Offset = "0x496A220", VA = "0x18496B420", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x496B420", Offset = "0x496A220", VA = "0x18496B420", Slot = "11")]
	private IEnumerator WAAULASRGHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x496C950", Offset = "0x496B750", VA = "0x18496C950")]
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
		[Cpp2IlInjected.Address(RVA = "0xF319E0", Offset = "0xF307E0", VA = "0x180F319E0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF31A00", Offset = "0xF30800", VA = "0x180F31A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
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
	[Cpp2IlInjected.Address(RVA = "0x60212E0", Offset = "0x60200E0", VA = "0x1860212E0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6020F70", Offset = "0x601FD70", VA = "0x186020F70", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6020690", Offset = "0x601F490", VA = "0x186020690", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class OCLLVMXQJVW<a>
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
	private const int SVVMMCNUDOR = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float JPBGSGWSZGC = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly BufferEntry[] BQMZHNOKKYE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int FQHPNIPMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float ERBPUPSMKVD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xE0A9E0", Offset = "0xE097E0", VA = "0x180E0A9E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE553C0", Offset = "0xE541C0", VA = "0x180E553C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public a GJOIFBPXFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1A05B10", Offset = "0x1A04910", VA = "0x181A05B10")]
		[CompilerGenerated]
		get
		{
			return (a)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5B56070", Offset = "0x5B54E70", VA = "0x185B56070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B56270", Offset = "0x5B55070", VA = "0x185B56270")]
	protected OCLLVMXQJVW()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5B563F0", Offset = "0x5B551F0", VA = "0x185B563F0")]
	protected OCLLVMXQJVW(int a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5B55CE0", Offset = "0x5B54AE0", VA = "0x185B55CE0")]
	public void Add(float time, a value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DUWGDNDDNLJ(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool RSWUKFXYFNK(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5B561F0", Offset = "0x5B54FF0", VA = "0x185B561F0")]
	public void Clear()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CUKNFFNXENL : OCLLVMXQJVW<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8441010", Offset = "0x843FE10", VA = "0x188441010", Slot = "4")]
	public override bool DUWGDNDDNLJ(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8441170", Offset = "0x843FF70", VA = "0x188441170", Slot = "5")]
	public override bool RSWUKFXYFNK(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84412B0", Offset = "0x84400B0", VA = "0x1884412B0")]
	public CUKNFFNXENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D4F240", Offset = "0x3D4E040", VA = "0x183D4F240")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D4F340", Offset = "0x3D4E140", VA = "0x183D4F340")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5A06480", Offset = "0x5A05280", VA = "0x185A06480")]
	internal static int FBYYPKEEHWC(int a, int b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75E6F40", Offset = "0x75E5D40", VA = "0x1875E6F40")]
	internal static int FBYYPKEEHWC(int a, int b, int c)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class Tuple<T1, T2> : IComparable<Tuple<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 OEHILSLLDIX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 OEMPIZFIMUG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6276350", Offset = "0x6275150", VA = "0x186276350")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x626D740", Offset = "0x626C540", VA = "0x18626D740", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x626EC50", Offset = "0x626DA50", VA = "0x18626EC50", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x626F270", Offset = "0x626E070", VA = "0x18626F270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6275AD0", Offset = "0x62748D0", VA = "0x186275AD0", Slot = "3")]
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
	public readonly T1 OEHILSLLDIX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 OEMPIZFIMUG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 OERWGFZFWFP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x627A370", Offset = "0x6279170", VA = "0x18627A370")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6276390", Offset = "0x6275190", VA = "0x186276390", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6276AE0", Offset = "0x62758E0", VA = "0x186276AE0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6277380", Offset = "0x6276180", VA = "0x186277380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x627A200", Offset = "0x6279000", VA = "0x18627A200", Slot = "3")]
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
	public AnimationCurve IEKBDUIQJVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T PEJXPTVBCSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14A3820", Offset = "0x14A2620", VA = "0x1814A3820")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T ALGZFDETEQO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC580B0", Offset = "0xC56EB0", VA = "0x180C580B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T XDXPKJAQNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2F75260", Offset = "0x2F74060", VA = "0x182F75260")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2F75190", Offset = "0x2F73F90", VA = "0x182F75190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GIENFZNRPSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xDF8D20", Offset = "0xDF7B20", VA = "0x180DF8D20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x64A1F90", Offset = "0x64A0D90", VA = "0x1864A1F90")]
	public T XXXGISASWOM(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x64A2360", Offset = "0x64A1160", VA = "0x1864A2360")]
	public T YDPZQUTKNLM(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FZEKURUHQCW(T a, T b, float c);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84415C0", Offset = "0x84403C0", VA = "0x1884415C0", Slot = "4")]
	protected override float FZEKURUHQCW(float a, float b, float c)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8441600", Offset = "0x8440400", VA = "0x188441600")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A94EA0", Offset = "0x1A93CA0", VA = "0x181A94EA0", Slot = "4")]
	protected override Vector3 FZEKURUHQCW(Vector3 a, Vector3 b, float c)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8444A80", Offset = "0x8443880", VA = "0x188444A80")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84412F0", Offset = "0x84400F0", VA = "0x1884412F0", Slot = "4")]
	protected override Color FZEKURUHQCW(Color a, Color b, float c)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84413B0", Offset = "0x84401B0", VA = "0x1884413B0")]
	public ColorValueCurve()
	{
	}
}
namespace Structures.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class VILDLFSSUFL : TCOEQWISCPX<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8444A30", Offset = "0x8443830", VA = "0x188444A30")]
		public VILDLFSSUFL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84449C0", Offset = "0x84437C0", VA = "0x1884449C0", Slot = "6")]
		protected override uint PLHGOBMYRTX(uint a, string b)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class COQXXRTPZWB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly IDisposable VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public COQXXRTPZWB()
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
		[Cpp2IlInjected.Address(RVA = "0x5A08DC0", Offset = "0x5A07BC0", VA = "0x185A08DC0")]
		private AwaitableRpc(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> roundTripRequests, int lastActorId, int requestId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBEC0", Offset = "0x6FBACC0", VA = "0x186FBBEC0")]
		public static AwaitableRpc<T> New()
		{
			return default(AwaitableRpc<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC050", Offset = "0x6FBAE50", VA = "0x186FBC050")]
		public (int, int, Task<T>) YHTAUSDOGZQ(int a, [Optional] CancellationToken b, double c = 60.0)
		{
			return default((int, int, Task<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB890", Offset = "0x6FBA690", VA = "0x186FBB890")]
		public void AWKTHSPEEVX(int a, int b, [In] T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class WVXZMBAVJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8444B40", Offset = "0x8443940", VA = "0x188444B40")]
		public static AwaitableRpc<None> New()
		{
			return default(AwaitableRpc<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8444AC0", Offset = "0x84438C0", VA = "0x188444AC0")]
		public static void AWKTHSPEEVX([In] this AwaitableRpc<None> self, int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class JXLRMXDYLYE<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Dictionary<a, b> FXKRUODGEWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Dictionary<b, a> TGCGSTQBCQU;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x52C8570", Offset = "0x52C7370", VA = "0x1852C8570", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x52C8960", Offset = "0x52C7760", VA = "0x1852C8960", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x52C8990", Offset = "0x52C7790", VA = "0x1852C8990", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x52C8630", Offset = "0x52C7430", VA = "0x1852C8630", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x52C8AA0", Offset = "0x52C78A0", VA = "0x1852C8AA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public a this[b key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x52C8900", Offset = "0x52C7700", VA = "0x1852C8900")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x52C6A80", Offset = "0x52C5880", VA = "0x1852C6A80", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x52C82B0", Offset = "0x52C70B0", VA = "0x1852C82B0", Slot = "20")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x52C6660", Offset = "0x52C5460", VA = "0x1852C6660", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x52C64F0", Offset = "0x52C52F0", VA = "0x1852C64F0", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x52C6C30", Offset = "0x52C5A30", VA = "0x1852C6C30", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x52C6DC0", Offset = "0x52C5BC0", VA = "0x1852C6DC0", Slot = "16")]
		public bool Contains(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x52C7E90", Offset = "0x52C6C90", VA = "0x1852C7E90", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x52C7E90", Offset = "0x52C6C90", VA = "0x1852C7E90", Slot = "18")]
		public bool Remove(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x52C81C0", Offset = "0x52C6FC0", VA = "0x1852C81C0", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x52C7480", Offset = "0x52C6280", VA = "0x1852C7480", Slot = "19")]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x52C6EF0", Offset = "0x52C5CF0", VA = "0x1852C6EF0", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x52C7520", Offset = "0x52C6320", VA = "0x1852C7520")]
		public bool HHYTRHIEAWJ(b a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x52C79B0", Offset = "0x52C67B0", VA = "0x1852C79B0")]
		private void JYMNZYDNWYX(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x52C7A80", Offset = "0x52C6880", VA = "0x1852C7A80")]
		private void LBQPBAVHUTK(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x52C7010", Offset = "0x52C5E10", VA = "0x1852C7010")]
		private bool FULJXEVAJMW(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x52C84A0", Offset = "0x52C72A0", VA = "0x1852C84A0")]
		public JXLRMXDYLYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class RYXUCSNNZWX<a> : IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private RYXUCSNNZWX<a> buffer;

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
				[Cpp2IlInjected.Address(RVA = "0x498A410", Offset = "0x4989210", VA = "0x18498A410", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x49988A0", Offset = "0x49976A0", VA = "0x1849988A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x499A0E0", Offset = "0x4998EE0", VA = "0x18499A0E0")]
			public Enumerator(RYXUCSNNZWX<a> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4997DA0", Offset = "0x4996BA0", VA = "0x184997DA0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4997AD0", Offset = "0x49968D0", VA = "0x184997AD0", Slot = "8")]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x4997A60", Offset = "0x4996860", VA = "0x184997A60")]
			private void ILDNBNUMMHF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private a[] JREFBMVTJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int WQPECUPCJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int WFNYXNMNQIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int version;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x5DC33C0", Offset = "0x5DC21C0", VA = "0x185DC33C0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5DC3440", Offset = "0x5DC2240", VA = "0x185DC3440")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5DC3530", Offset = "0x5DC2330", VA = "0x185DC3530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3340", Offset = "0x5DC2140", VA = "0x185DC3340")]
		public RYXUCSNNZWX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2480", Offset = "0x5DC1280", VA = "0x185DC2480")]
		public void Add(a t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2770", Offset = "0x5DC1570", VA = "0x185DC2770")]
		public void FNBDZJZQLOP(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC25F0", Offset = "0x5DC13F0", VA = "0x185DC25F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC31E0", Offset = "0x5DC1FE0", VA = "0x185DC31E0")]
		public void NTKYHZVKDZQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2610", Offset = "0x5DC1410", VA = "0x185DC2610")]
		public void CopyTo(a[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3010", Offset = "0x5DC1E10", VA = "0x185DC3010")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3100", Offset = "0x5DC1F00", VA = "0x185DC3100", Slot = "4")]
		private IEnumerator<a> HRBGLFUMDTX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3100", Offset = "0x5DC1F00", VA = "0x185DC3100", Slot = "5")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3260", Offset = "0x5DC2060", VA = "0x185DC3260")]
		private int UYFJTWNVEHW(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DC31B0", Offset = "0x5DC1FB0", VA = "0x185DC31B0")]
		private int KYOXPQBHSXO(int a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class JRDFLZEHNJE<a, b> : IDisposable
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
		public class GKARUJBCWRJ
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private const float WRAFJSOWEVV = 60f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TimeSpan QKMBUDKXGPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int DSMSZFELNJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ProcessMethod FTSARPKQMDX;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly GKARUJBCWRJ SNTFEPMFQUI;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public float BXVECSEMHHW
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x50A91D0", Offset = "0x50A7FD0", VA = "0x1850A91D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public TimeSpan GCKMUMTLHOT
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				get
				{
					return default(TimeSpan);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x50A9510", Offset = "0x50A8310", VA = "0x1850A9510")]
			public GKARUJBCWRJ()
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
			[Cpp2IlInjected.Address(RVA = "0x5D142E0", Offset = "0x5D130E0", VA = "0x185D142E0")]
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
			public JRDFLZEHNJE<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private QueueItem <req>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x50224E0", Offset = "0x50212E0", VA = "0x1850224E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x5023B50", Offset = "0x5022950", VA = "0x185023B50", Slot = "5")]
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
			public JRDFLZEHNJE<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x54F0B40", Offset = "0x54EF940", VA = "0x1854F0B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x54F1600", Offset = "0x54F0400", VA = "0x1854F1600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CancellationTokenSource KVWTCYABGMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly List<QueueItem> JZCLBWGHRYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly GKARUJBCWRJ NERACMSYHXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly RequestProcessor GKNLYSUUQUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Task DNGKHAGMAYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int BZZSCCYXIMA;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x52BC2B0", Offset = "0x52BB0B0", VA = "0x1852BC2B0")]
		public JRDFLZEHNJE(RequestProcessor a, [Optional] GKARUJBCWRJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x52BA700", Offset = "0x52B9500", VA = "0x1852BA700")]
		public Task<b> GSWKUUSIWWT(a a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x52BBCF0", Offset = "0x52BAAF0", VA = "0x1852BBCF0")]
		private void TGRFUBSGTGO(QueueItem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x52BB830", Offset = "0x52BA630", VA = "0x1852BB830")]
		[AsyncStateMachine(typeof(JRDFLZEHNJE<, >.<StartQueueProcess>d__12))]
		private Task NSBKGNPFHLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x52BB1F0", Offset = "0x52B9FF0", VA = "0x1852BB1F0")]
		private QueueItem KXUCYCETLVN()
		{
			return default(QueueItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x52BBAF0", Offset = "0x52BA8F0", VA = "0x1852BBAF0")]
		[AsyncStateMachine(typeof(JRDFLZEHNJE<, >.<DequeueItemAndRun>d__14))]
		private Task SUCHRFPESQC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x52BA440", Offset = "0x52B9240", VA = "0x1852BA440")]
		private void BQBGLQQLAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x52BA6C0", Offset = "0x52B94C0", VA = "0x1852BA6C0", Slot = "4")]
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
	public class WQVZFBKSUPW<a> : IList<a>, ICollection<a>, IEnumerable<a>, IEnumerable, IReadOnlyList<a>, IReadOnlyCollection<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly List<a> OCHNSJMGFTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HashSet<a> SFPOUXHYOOR;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB4B2C0", Offset = "0xB4A0C0", VA = "0x180B4B2C0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x681E6E0", Offset = "0x681D4E0", VA = "0x18681E6E0", Slot = "18")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x681E9E0", Offset = "0x681D7E0", VA = "0x18681E9E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x681D590", Offset = "0x681C390", VA = "0x18681D590", Slot = "11")]
		public void Add(a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x681DB70", Offset = "0x681C970", VA = "0x18681DB70")]
		public bool HUHLLCKKILF(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x681E450", Offset = "0x681D250", VA = "0x18681E450", Slot = "15")]
		public bool Remove(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x681D910", Offset = "0x681C710", VA = "0x18681D910", Slot = "16")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x681E4D0", Offset = "0x681D2D0", VA = "0x18681E4D0", Slot = "17")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x681D6C0", Offset = "0x681C4C0", VA = "0x18681D6C0", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x681D700", Offset = "0x681C500", VA = "0x18681D700", Slot = "13")]
		public bool Contains(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x681D810", Offset = "0x681C610", VA = "0x18681D810", Slot = "14")]
		public void CopyTo(a[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x681DD30", Offset = "0x681CB30", VA = "0x18681DD30", Slot = "6")]
		public int IndexOf(a item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x681DD60", Offset = "0x681CB60", VA = "0x18681DD60", Slot = "7")]
		public void Insert(int index, a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x681E240", Offset = "0x681D040", VA = "0x18681E240", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x681E610", Offset = "0x681D410", VA = "0x18681E610")]
		public WQVZFBKSUPW()
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
		private Guid KPJUPYHRTCJ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4D80", Offset = "0x2DA3B80", VA = "0x182DA4D80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8443D60", Offset = "0x8442B60", VA = "0x188443D60")]
		public SerializedGuid([In] Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8443BD0", Offset = "0x84429D0", VA = "0x188443BD0")]
		public static SerializedGuid KSFOZWANPIY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8443C40", Offset = "0x8442A40", VA = "0x188443C40")]
		public static SerializedGuid NXSLSUIEUVI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8443B70", Offset = "0x8442970", VA = "0x188443B70")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8443D30", Offset = "0x8442B30", VA = "0x188443D30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8443CB0", Offset = "0x8442AB0", VA = "0x188443CB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8443A90", Offset = "0x8442890", VA = "0x188443A90", Slot = "7")]
		public bool Equals(SerializedGuid other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8443AD0", Offset = "0x84428D0", VA = "0x188443AD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8443B60", Offset = "0x8442960", VA = "0x188443B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8443A60", Offset = "0x8442860", VA = "0x188443A60", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x84439F0", Offset = "0x84427F0", VA = "0x1884439F0")]
		public SerializedGuidSourceAttribute(Type valueRetrieveMethodType, string valueRetrieveMethod, bool insertEmptyChoice = false, bool disabled = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface OAGZRXIGGXK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		int PQIKBLERCUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<a> ZMPVBFRDOAA(float a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DQVORMUXSMK(float a, a b);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class XZLQGYACEMX<a> : OAGZRXIGGXK<a>
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
			[Cpp2IlInjected.Address(RVA = "0x1097CD0", Offset = "0x1096AD0", VA = "0x181097CD0")]
			public Sample(a value, float time)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class QGOBMIDHSNO : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private a KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public XZLQGYACEMX<a> SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private float SZVVMMEZSKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float ZOTLVBYFLHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float? OTKGPGTLLSY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float? OMJWKRQUQQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int UTQIDKYCHZF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int AHDLFLQBNIM;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private a WNWBIZYQFPY
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xF47470", Offset = "0xF46270", VA = "0x180F47470", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x50144B0", Offset = "0x50132B0", VA = "0x1850144B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x15ECBD0", Offset = "0x15EB9D0", VA = "0x1815ECBD0")]
			[DebuggerHidden]
			public QGOBMIDHSNO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5CFDE00", Offset = "0x5CFCC00", VA = "0x185CFDE00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x402B990", Offset = "0x402A790", VA = "0x18402B990", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x5CFDD40", Offset = "0x5CFCB40", VA = "0x185CFDD40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> HRBGLFUMDTX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x5CFE430", Offset = "0x5CFD230", VA = "0x185CFE430", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly float WTZZJFRXRLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly float BMBIGYBOEJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly List<Sample> RLEUXVUPXQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int WQPECUPCJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int LLTNGOWHKPE;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int PQIKBLERCUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x40A8EF0", Offset = "0x40A7CF0", VA = "0x1840A8EF0")]
		public XZLQGYACEMX(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x40A8260", Offset = "0x40A7060", VA = "0x1840A8260", Slot = "6")]
		public bool DQVORMUXSMK(float a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x40A81C0", Offset = "0x40A6FC0", VA = "0x1840A81C0", Slot = "8")]
		public int CUZDXTLWXVS(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x40A8C70", Offset = "0x40A7A70", VA = "0x1840A8C70", Slot = "5")]
		[IteratorStateMachine(typeof(XZLQGYACEMX<>.QGOBMIDHSNO))]
		public IEnumerable<a> ZMPVBFRDOAA(float a, float? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x40A81F0", Offset = "0x40A6FF0", VA = "0x1840A81F0", Slot = "7")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x40A8920", Offset = "0x40A7720", VA = "0x1840A8920")]
		private void PXEHPFBWRCN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x40A8AC0", Offset = "0x40A78C0", VA = "0x1840A8AC0")]
		private Sample YVPURXIUNZR()
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
			[Cpp2IlInjected.Address(RVA = "0x624CB20", Offset = "0x624B920", VA = "0x18624CB20")]
			public TimerEntry(long startTicks, int startFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x624CAF0", Offset = "0x624B8F0", VA = "0x18624CAF0")]
			public TimerEntry(long startTicks, long endTicks, int startFrame, int endFrame, bool isDone, string stackTrace)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x624C960", Offset = "0x624B760", VA = "0x18624C960")]
			public int KOEJVGPCSZB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x624C8C0", Offset = "0x624B6C0", VA = "0x18624C8C0")]
			public int FJMJFXPKBDL(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x624C800", Offset = "0x624B600", VA = "0x18624C800")]
			public double BMCELWSAKKV()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x624C9B0", Offset = "0x624B7B0", VA = "0x18624C9B0")]
			public TimerEntry PXHOLSHDYHK(long a, int b)
			{
				return default(TimerEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class KRKAYPFWOVG : IDisposable
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
				public KRKAYPFWOVG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public TKey key;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				public Func<KRKAYPFWOVG, Task<T>> function;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				private KRKAYPFWOVG <internalTimer>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				private TaskAwaiter<T> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x559A710", Offset = "0x5599510", VA = "0x18559A710", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x50388D0", Offset = "0x50376D0", VA = "0x1850388D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public readonly TKey UWPCMRAPJZQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private readonly StackTimer<TKey> TDVJQKCJDEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public readonly Log YLLVKVFSHML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private List<KRKAYPFWOVG> VOBEZFUGVTY;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public string CQFVQKRLJVE
			{
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x53BFB20", Offset = "0x53BE920", VA = "0x1853BFB20")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public IEnumerable<KRKAYPFWOVG> GMWEVQQOKDC
			{
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x53BF9E0", Offset = "0x53BE7E0", VA = "0x1853BF9E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public TimerEntry PCVXIUOFPFC
			{
				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x237CCF0", Offset = "0x237BAF0", VA = "0x18237CCF0")]
				[CompilerGenerated]
				get
				{
					return default(TimerEntry);
				}
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x53BFA70", Offset = "0x53BE870", VA = "0x1853BFA70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x53BFE90", Offset = "0x53BEC90", VA = "0x1853BFE90")]
			internal KRKAYPFWOVG(StackTimer<TKey> a, TKey b, Log c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x53BF3E0", Offset = "0x53BE1E0", VA = "0x1853BF3E0")]
			public KRKAYPFWOVG ELZJUFFQOTK(TKey a, [Optional] Log? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x3A61530", Offset = "0x3A60330", VA = "0x183A61530")]
			[AsyncStateMachine(typeof(<WrapAsync>d__17<>))]
			public Task<b> CORNPLZVXDX<b>(TKey a, Func<KRKAYPFWOVG, Task<b>> b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x53BF2B0", Offset = "0x53BE0B0", VA = "0x1853BF2B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class JKITCPAKBZO : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public StackTimer<TKey> SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> RSQQLXOAUXF;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private (TKey, List<TKey>, TimerEntry) PKYRERPRDCF
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x2DA6E10", Offset = "0x2DA5C10", VA = "0x182DA6E10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x52B6ED0", Offset = "0x52B5CD0", VA = "0x1852B6ED0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2DA7760", Offset = "0x2DA6560", VA = "0x182DA7760")]
			[DebuggerHidden]
			public JKITCPAKBZO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x52B65F0", Offset = "0x52B53F0", VA = "0x1852B65F0", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x52B6BC0", Offset = "0x52B59C0", VA = "0x1852B6BC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x52B72B0", Offset = "0x52B60B0", VA = "0x1852B72B0")]
			private void XVTZRJOPNYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x402B990", Offset = "0x402A790", VA = "0x18402B990", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x52B7120", Offset = "0x52B5F20", VA = "0x1852B7120", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> WWUKSJMOPGO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x52B6F20", Offset = "0x52B5D20", VA = "0x1852B6F20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class JKNZZVUHLKX : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private List<TKey> HMCJLWVXEBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public List<TKey> ITJQYZJIJTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private KRKAYPFWOVG KHTKVFJSZUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public KRKAYPFWOVG TYKUGNOUCWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public StackTimer<TKey> SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private IEnumerator<KRKAYPFWOVG> RSQQLXOAUXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> RSVXJEHYEIO;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			private (TKey, List<TKey>, TimerEntry) PKYRERPRDCF
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2DA6E10", Offset = "0x2DA5C10", VA = "0x182DA6E10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0x52B8970", Offset = "0x52B7770", VA = "0x1852B8970", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2DA7760", Offset = "0x2DA6560", VA = "0x182DA7760")]
			[DebuggerHidden]
			public JKNZZVUHLKX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x52B7300", Offset = "0x52B6100", VA = "0x1852B7300", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x52B7530", Offset = "0x52B6330", VA = "0x1852B7530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x52B8DA0", Offset = "0x52B7BA0", VA = "0x1852B8DA0")]
			private void XVTZRJOPNYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x52B8EE0", Offset = "0x52B7CE0", VA = "0x1852B8EE0")]
			private void XWJUJDWHQGV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x402B990", Offset = "0x402A790", VA = "0x18402B990", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x52B8CD0", Offset = "0x52B7AD0", VA = "0x1852B8CD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> WWUKSJMOPGO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x52B89C0", Offset = "0x52B77C0", VA = "0x1852B89C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Action<TKey, TimerEntry, Log> WKNAIMJORZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Action<TKey, TimerEntry, Log> JEUOYSJFKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Action<StackTimer<TKey>, Log> NKNDIKNBMXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly KRKAYPFWOVG MOMHMUMLPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool KTWIZWBHUSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int QVOHBMYQHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Stopwatch SHOVXCHFILY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly int TGGTJKAILHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private string DXEWJVSBVAR;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public KRKAYPFWOVG LCEATSQDJOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		[NotNull]
		public string CQFVQKRLJVE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA19A0", Offset = "0xAA07A0", VA = "0x180AA19A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x60C6CA0", Offset = "0x60C5AA0", VA = "0x1860C6CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60C6F40", Offset = "0x60C5D40", VA = "0x1860C6F40")]
		public StackTimer(TKey rootKey, Log log, [Optional] int? startFrame, [Optional][CanBeNull] Stopwatch stopwatch, [Optional] Action<TKey, TimerEntry, Log> pushCallback, [Optional] Action<TKey, TimerEntry, Log> popCallback, [Optional] Action<StackTimer<TKey>, Log> disposeCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60C6A00", Offset = "0x60C5800", VA = "0x1860C6A00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60C66A0", Offset = "0x60C54A0", VA = "0x1860C66A0")]
		[IteratorStateMachine(typeof(StackTimer<>.JKITCPAKBZO))]
		public IEnumerable<(TKey, List<TKey>, TimerEntry)> AVUJWNWAVEU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60C6940", Offset = "0x60C5740", VA = "0x1860C6940")]
		[IteratorStateMachine(typeof(StackTimer<>.JKNZZVUHLKX))]
		private IEnumerable<(TKey, List<TKey>, TimerEntry)> AVUJWNWAVEU(List<TKey> a, KRKAYPFWOVG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x60C6B40", Offset = "0x60C5940", VA = "0x1860C6B40")]
		private (long, int) Now()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class SYLIKSDNQZM<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b Format(StackTimer<a> timer);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected SYLIKSDNQZM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class LKDOOBEKNGR<a> : SYLIKSDNQZM<a, string>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5489FA0", Offset = "0x5488DA0", VA = "0x185489FA0")]
		private static string PVQVJAZEDOD(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5489E70", Offset = "0x5488C70", VA = "0x185489E70", Slot = "4")]
		public override string Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5489BA0", Offset = "0x54889A0", VA = "0x185489BA0")]
		public string Format(StackTimer<a> timer, [NotNull] KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract string QXGGWADKLBT(StackTimer<a> a, [NotNull] KeyToStringFunc keyToStringFunc);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x548A0E0", Offset = "0x5488EE0", VA = "0x18548A0E0")]
		protected LKDOOBEKNGR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class FLHJXPWNYKR<a> : SYLIKSDNQZM<a, Dictionary<string, string>>
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string CTZKLMSGRDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly double INYDZBSDOAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly bool UJNUTFUMNDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly int VILHXCDAOXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ISet<string> NEEAPRVSAVO;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4F38790", Offset = "0x4F37590", VA = "0x184F38790")]
		private static string PVQVJAZEDOD(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4F38C50", Offset = "0x4F37A50", VA = "0x184F38C50")]
		public FLHJXPWNYKR(string a = "F2", double b = 1.7976931348623157E+308, bool c = false, int d = 2147483647, [Optional] ISet<string> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4F37500", Offset = "0x4F36300", VA = "0x184F37500", Slot = "4")]
		public override Dictionary<string, string> Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4F38BE0", Offset = "0x4F379E0", VA = "0x184F38BE0")]
		private bool ZBGPYUKTETP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4F37630", Offset = "0x4F36430", VA = "0x184F37630")]
		public Dictionary<string, string> Format(StackTimer<a> timer, KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4F38350", Offset = "0x4F37150", VA = "0x184F38350")]
		private string KTEPAYLCQQE(StringBuilder a, List<a> b, KeyToStringFunc c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4F38A20", Offset = "0x4F37820", VA = "0x184F38A20")]
		private static void TMMERUPRVGI(StringBuilder a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AUEOIJHDZKE<a> : LKDOOBEKNGR<a>
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
		public static AUEOIJHDZKE<a> VDCQJFYBFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly string[] ULQATIEGEBX;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5633280", Offset = "0x5632080", VA = "0x185633280")]
		private AUEOIJHDZKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5632390", Offset = "0x5631190", VA = "0x185632390", Slot = "5")]
		protected override string QXGGWADKLBT(StackTimer<a> a, KeyToStringFunc b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5631510", Offset = "0x5630310", VA = "0x185631510")]
		[CompilerGenerated]
		internal static string NVIQJSZLDFL(string a, a b, <>c__DisplayClass4_0 c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class JXIRWEMCHHZ : StackTimer<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class JSZUEIUUAJQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public Action<JXIRWEMCHHZ, Log> ZUETPAWZPNC;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public JSZUEIUUAJQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8441640", Offset = "0x8440440", VA = "0x188441640")]
			internal void TITYONAHNPP(StackTimer<string> a, Log b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8441790", Offset = "0x8440590", VA = "0x188441790")]
		public JXIRWEMCHHZ(Log a, [Optional] string b, [Optional] int? c, [Optional] Stopwatch d, [Optional] Action<string, TimerEntry, Log> e, [Optional] Action<string, TimerEntry, Log> f, [Optional] Action<JXIRWEMCHHZ, Log> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84416D0", Offset = "0x84404D0", VA = "0x1884416D0")]
		private static Action<StackTimer<string>, Log> CMXGZAWFVSH(Action<JXIRWEMCHHZ, Log> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class DPAEEXIPQAD
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private class XZYCSJZTWUQ : DPAEEXIPQAD
		{
			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static DPAEEXIPQAD VDCQJFYBFAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x8444B90", Offset = "0x8443990", VA = "0x188444B90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override float OWEWNXAEKFL
			{
				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0x1441680", Offset = "0x1440480", VA = "0x181441680", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8444C80", Offset = "0x8443A80", VA = "0x188444C80")]
			public XZYCSJZTWUQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static DPAEEXIPQAD SDESOYRDNVO;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static DPAEEXIPQAD SNTFEPMFQUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x84413F0", Offset = "0x84401F0", VA = "0x1884413F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract float OWEWNXAEKFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected DPAEEXIPQAD()
		{
		}
	}
}
namespace RecRoom.DataStructures.ResourceHandles
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface YAYJHRRBOEM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool ONCGHIYWMTS
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface SQZZORITPNB<a> : YAYJHRRBOEM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[NotNull]
		Task<a> PRSDEJIPCXE
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[NotNull]
		WCGMKCSPRXW<a> PQFAKRQEOUY
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class WOEWOCQCWCU
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3E97CE0", Offset = "0x3E96AE0", VA = "0x183E97CE0")]
		public static SQZZORITPNB<TResource> GHSBDOCHDPT<TResource, a>(this QHMFMWPCQWS<a, TResource> a, a b, [Optional] Func<a, CancellationToken, Task<TResource>>? resourceFactory) where TResource : notnull where a : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class YIVWFBESHTD
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class YLZUMBJJGFX<a> : CRGCCOOWEBZ<a?> where a : class
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override Task<a?> PRSDEJIPCXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override WCGMKCSPRXW<a?> PQFAKRQEOUY
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x410F110", Offset = "0x410DF10", VA = "0x18410F110")]
			public YLZUMBJJGFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "10")]
			protected override void KCBMTJTGMRJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class RUWSAEUUDXZ<a> : CRGCCOOWEBZ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private readonly a IYJFOILBUME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private readonly Action<a>? FYWJRLRRLKC;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public override Task<a> PRSDEJIPCXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override WCGMKCSPRXW<a> PQFAKRQEOUY
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x5D639F0", Offset = "0x5D627F0", VA = "0x185D639F0")]
			public RUWSAEUUDXZ(a a, Action<a>? onDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5D63690", Offset = "0x5D62490", VA = "0x185D63690", Slot = "10")]
			protected override void KCBMTJTGMRJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class FOXTOZZPAZT<a> : CRGCCOOWEBZ<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override Task<a> PRSDEJIPCXE
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override WCGMKCSPRXW<a> PQFAKRQEOUY
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4F3A6B0", Offset = "0x4F394B0", VA = "0x184F3A6B0")]
			public FOXTOZZPAZT(Exception a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "10")]
			protected override void KCBMTJTGMRJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class NUWKYEVIIIL<a> : CRGCCOOWEBZ<a> where a : notnull
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
				public Task<SQZZORITPNB<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				private TaskAwaiter<SQZZORITPNB<a>> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				private TaskAwaiter<a> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x3FA3B40", Offset = "0x3FA2940", VA = "0x183FA3B40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x3FA4AF0", Offset = "0x3FA38F0", VA = "0x183FA4AF0", Slot = "5")]
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
				public Task<SQZZORITPNB<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				private TaskAwaiter<SQZZORITPNB<a>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3FA74B0", Offset = "0x3FA62B0", VA = "0x183FA74B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x3FA7B40", Offset = "0x3FA6940", VA = "0x183FA7B40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private readonly Task<SQZZORITPNB<a>> NVSRFIBMQFT;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override Task<a> PRSDEJIPCXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override WCGMKCSPRXW<a> PQFAKRQEOUY
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5A40DC0", Offset = "0x5A3FBC0", VA = "0x185A40DC0")]
			public NUWKYEVIIIL(Task<SQZZORITPNB<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5A403B0", Offset = "0x5A3F1B0", VA = "0x185A403B0", Slot = "10")]
			protected override void KCBMTJTGMRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x5A40A70", Offset = "0x5A3F870", VA = "0x185A40A70")]
			[AsyncStateMachine(typeof(NUWKYEVIIIL<>.<<-ctor>g__Unwrap|7_0>d))]
			[CompilerGenerated]
			internal static Task<a> OCEECZVPTNZ(Task<SQZZORITPNB<a>> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5A407F0", Offset = "0x5A3F5F0", VA = "0x185A407F0")]
			[AsyncStateMachine(typeof(NUWKYEVIIIL<>.<<OnDispose>g__AwaitThenDispose|8_0>d))]
			[CompilerGenerated]
			internal static Task NZRNAMWKSWJ(Task<SQZZORITPNB<a>> a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private sealed class JWFWARPPQWJ<a, b> : CRGCCOOWEBZ<b> where a : notnull where b : notnull
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
				[Cpp2IlInjected.Address(RVA = "0x3FA3150", Offset = "0x3FA1F50", VA = "0x183FA3150", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x3FA3AB0", Offset = "0x3FA28B0", VA = "0x183FA3AB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly SQZZORITPNB<a> FSEIDUOKAGK;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override Task<b> PRSDEJIPCXE
			{
				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override WCGMKCSPRXW<b> PQFAKRQEOUY
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x52C47A0", Offset = "0x52C35A0", VA = "0x1852C47A0")]
			public JWFWARPPQWJ(SQZZORITPNB<a> a, Func<a, b> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4300", Offset = "0x52C3100", VA = "0x1852C4300", Slot = "10")]
			protected override void KCBMTJTGMRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4500", Offset = "0x52C3300", VA = "0x1852C4500")]
			[AsyncStateMachine(typeof(JWFWARPPQWJ<, >.<<-ctor>g__Transform|7_0>d))]
			[CompilerGenerated]
			internal static Task<b> OXUWLYYGNYM(Task<a> a, Func<a, b> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDC00", Offset = "0x3EECA00", VA = "0x183EEDC00")]
		public static SQZZORITPNB<T> Empty<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDD60", Offset = "0x3EECB60", VA = "0x183EEDD60")]
		public static SQZZORITPNB<T> HIMBJJINSZQ<T>(T a, [Optional] Action<T>? onDispose) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE00", Offset = "0x3EECC00", VA = "0x183EEDE00")]
		public static SQZZORITPNB<T> LHYHSKCSYMU<T>(Exception a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE70", Offset = "0x3EECC70", VA = "0x183EEDE70")]
		public static SQZZORITPNB<T> PBDIDLFCOHU<T>(Task<SQZZORITPNB<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDF50", Offset = "0x3EECD50", VA = "0x183EEDF50")]
		public static SQZZORITPNB<TOut> Transform<TOut, TIn>(SQZZORITPNB<TIn> handle, Func<TIn, TOut> transformFunc) where TOut : notnull where TIn : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public abstract class CRGCCOOWEBZ<a> : SQZZORITPNB<a>, YAYJHRRBOEM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static readonly string RKSGINWEYQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DisposeReminder TIXQQDFNUBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private bool KTWIZWBHUSQ;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool ONCGHIYWMTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xBF7480", Offset = "0xBF6280", VA = "0x180BF7480", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract Task<a> PRSDEJIPCXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public abstract WCGMKCSPRXW<a> PQFAKRQEOUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4037F10", Offset = "0x4036D10", VA = "0x184037F10")]
		public CRGCCOOWEBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4037B90", Offset = "0x4036990", VA = "0x184037B90", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void KCBMTJTGMRJ();
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class CRLIZVITNNI<a, b> : CRGCCOOWEBZ<b> where a : Task
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class CORIYCNATUY
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
				public CORIYCNATUY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x3FA2D40", Offset = "0x3FA1B40", VA = "0x183FA2D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3FA3000", Offset = "0x3FA1E00", VA = "0x183FA3000", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public CRLIZVITNNI<a, b> SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public CancellationToken LDPCYHRSWYW;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public CORIYCNATUY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x4032A70", Offset = "0x4031870", VA = "0x184032A70")]
			[AsyncStateMachine(typeof(CRLIZVITNNI<, >.CORIYCNATUY.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
			internal Task<b> MODOZPFYCWV(a a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Task<b> ZVXHOXWWNRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		protected readonly CancellationTokenSource TDRVAICITUI;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override Task<b> PRSDEJIPCXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override WCGMKCSPRXW<b> PQFAKRQEOUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x40381B0", Offset = "0x4036FB0", VA = "0x1840381B0")]
		protected CRLIZVITNNI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4037FB0", Offset = "0x4036DB0", VA = "0x184037FB0", Slot = "10")]
		protected override void KCBMTJTGMRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract b KUXOFSSAVNT(a a);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OQFVDMUFDRK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class HGHYQSJTYXP<a> : CRGCCOOWEBZ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly FFYKNYQSRAJ<Task<a>> HEMXKIKEBMD;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override Task<a> PRSDEJIPCXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xFDE650", Offset = "0xFDD450", VA = "0x180FDE650", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override WCGMKCSPRXW<a> PQFAKRQEOUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x50FFAD0", Offset = "0x50FE8D0", VA = "0x1850FFAD0")]
		public HGHYQSJTYXP(FFYKNYQSRAJ<Task<a>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x50FF9D0", Offset = "0x50FE7D0", VA = "0x1850FF9D0", Slot = "10")]
		protected override void KCBMTJTGMRJ()
		{
		}
	}
}
namespace RecRoom.DataStructures.Hashing
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class NDKNEZDWQGH
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly HashAlgorithmName BZIVFOVKLDR;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly ThreadLocal<IncrementalHash> JWMSORUBFAC;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8441BB0", Offset = "0x84409B0", VA = "0x188441BB0")]
		public static int RQDTRWCHWOM(this TSFGMBDUIRU a, IncrementalHash b, byte[] c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8441F40", Offset = "0x8440D40", VA = "0x188441F40")]
		public static bool VZHZAFFPEXP([CanBeNull] this TSFGMBDUIRU hashableAsset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8441C40", Offset = "0x8440A40", VA = "0x188441C40")]
		public static bool VZHZAFFPEXP([CanBeNull] this TSFGMBDUIRU hashableAsset, [Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8441FA0", Offset = "0x8440DA0", VA = "0x188441FA0")]
		public static bool VZHZAFFPEXP([CanBeNull] this TSFGMBDUIRU hashableAsset, IncrementalHash a, byte[] b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8441B20", Offset = "0x8440920", VA = "0x188441B20")]
		private static bool MFVVLIUTCKJ(byte[] a, Span<byte> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class VFOVBIVPZUZ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8444870", Offset = "0x8443670", VA = "0x188444870")]
		public static int WLLYWYOEEMO(HashAlgorithmName a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BA00", Offset = "0x3E7A800", VA = "0x183E7BA00")]
		public static int RQDTRWCHWOM<a>(this a a, byte[] b, IncrementalHash c, byte[] d) where a : VHIUCTLOYWO
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface VHIUCTLOYWO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AppendToHash([NotNull] IncrementalHash hash);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface TSFGMBDUIRU : VHIUCTLOYWO
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[CanBeNull]
		byte[] CWBNHGBKESU
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[CanBeNull]
		byte[] JMPCQOADGBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class ZPKYICXKDYP
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static bool WRJVZIJEOGT;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly ArrayPool<byte> OUBZBETCOPU;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly ArrayPool<char> QOMFSTBORSS;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly Encoding PEOYPFZZSHH;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ThreadLocal<Encoder> HEIYJYLYBIU;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE2D0", Offset = "0x3EFD0D0", VA = "0x183EFE2D0")]
		public static void GOEWWBBERKR<b>(this IncrementalHash a, [CanBeNull] b component) where b : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEDB0", Offset = "0x3EFDBB0", VA = "0x183EFEDB0")]
		public static void TIVREUCENYP<c>(this IncrementalHash a, [CanBeNull] c hashable) where c : VHIUCTLOYWO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE730", Offset = "0x3EFD530", VA = "0x183EFE730")]
		public static void MECEJJGSLYU<d>(this IncrementalHash a, [CanBeNull] IList<d> hashablesList) where d : VHIUCTLOYWO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84451D0", Offset = "0x8443FD0", VA = "0x1884451D0")]
		private static bool IQGZSJYXNTI([CanBeNull] VHIUCTLOYWO hashable)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8444DE0", Offset = "0x8443BE0", VA = "0x188444DE0")]
		public static void HQXDBLCHOVA(this IncrementalHash a, string? stringValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x84453D0", Offset = "0x84441D0", VA = "0x1884453D0")]
		public static void PKUQQDOFGCN(this IncrementalHash a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8445540", Offset = "0x8444340", VA = "0x188445540")]
		public static void RZGOKPUGOTS(this IncrementalHash a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8445770", Offset = "0x8444570", VA = "0x188445770")]
		public static void VZNUTRCQCHR(this IncrementalHash a, short b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8444CD0", Offset = "0x8443AD0", VA = "0x188444CD0")]
		public static void AIVMFZZINPL(this IncrementalHash a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8445260", Offset = "0x8444060", VA = "0x188445260")]
		public static void NCAMZGWKMQA(this IncrementalHash a, bool b, bool c = false, bool d = false, bool e = false, bool f = false, bool g = false, bool h = false, bool i = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD2A0", Offset = "0x3EFC0A0", VA = "0x183EFD2A0")]
		public static void CFHAWEKNAWK<e>(this IncrementalHash a, e b) where e : struct, Enum, IConvertible
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8445940", Offset = "0x8444740", VA = "0x188445940")]
		public static void YTYSIUFCIQD(this IncrementalHash a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x84458E0", Offset = "0x84446E0", VA = "0x1884458E0")]
		public static void XRCGFQACPOI(this IncrementalHash a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8445710", Offset = "0x8444510", VA = "0x188445710")]
		public static void THZXJCBUKBF(this IncrementalHash a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x84456B0", Offset = "0x84444B0", VA = "0x1884456B0")]
		public static void TBBQQDLMHSA(this IncrementalHash a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x84459A0", Offset = "0x84447A0", VA = "0x1884459A0")]
		public static void ZBFEKQZKXKF(this IncrementalHash a, Vector3 b)
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
		[Cpp2IlInjected.Address(RVA = "0x8441560", Offset = "0x8440360", VA = "0x188441560")]
		public DataDesyncException(string message)
		{
		}
	}
}
namespace RecRoom.Core.Scripts.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class DEYDHXRXCNN
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate void OnStateChange(ushort currentStateId, ushort previousStateId, ushort currentSubStateId, ushort previousSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate void StateTransition(ushort otherStateId, ushort otherSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public delegate void StateUpdate();

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public const ushort DDCBURQDMAU = 65535;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected DEYDHXRXCNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class YKODASZGMLW<a> : DEYDHXRXCNN where a : YKODASZGMLW<a>.MTQIKZNJYEX
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public interface MTQIKZNJYEX
		{
			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			StateTransition DZFXQWQUSQU
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			StateTransition EVUPNJTCCKW
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			StateUpdate SBCGSVQNQFZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<uint, a> YHFBSZMOWLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private StateUpdate BVZZMHMOYSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private StateUpdate KCRJRIJBSOC;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool FVGNCSNQOFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB869E0", VA = "0x180B87BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xAAD5B0", Offset = "0xAAC3B0", VA = "0x180AAD5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ushort WSSYJDKMECM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x130A0F0", Offset = "0x1308EF0", VA = "0x18130A0F0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x130A340", Offset = "0x1309140", VA = "0x18130A340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public ushort YHVMZIFUFFE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x410CBC0", Offset = "0x410B9C0", VA = "0x18410CBC0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x410D6B0", Offset = "0x410C4B0", VA = "0x18410D6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ushort XMKJBDTYARQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xFC94B0", Offset = "0xFC82B0", VA = "0x180FC94B0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xFC9570", Offset = "0xFC8370", VA = "0x180FC9570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ushort TBEVUWSYIUY
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x410D6A0", Offset = "0x410C4A0", VA = "0x18410D6A0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x410CEE0", Offset = "0x410BCE0", VA = "0x18410CEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected bool PQCNHYRNNDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x130A330", Offset = "0x1309130", VA = "0x18130A330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected bool FAFZGFFOMEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xC9D8F0", Offset = "0xC9C6F0", VA = "0x180C9D8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OnStateChange QBBNGAYLNVS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x410CB20", Offset = "0x410B920", VA = "0x18410CB20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x410CBD0", Offset = "0x410B9D0", VA = "0x18410CBD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x410EAC0", Offset = "0x410D8C0", VA = "0x18410EAC0")]
		private a WUNSFYDIROV(ushort a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x410CE70", Offset = "0x410BC70", VA = "0x18410CE70")]
		private a FVSHTCRTDCS(ushort a, ushort b)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x410D660", Offset = "0x410C460", VA = "0x18410D660")]
		protected a PFMDINVKZCY(uint a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x410EC00", Offset = "0x410DA00", VA = "0x18410EC00")]
		protected YKODASZGMLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x410D6C0", Offset = "0x410C4C0", VA = "0x18410D6C0")]
		public void UVUNRNLFMQU(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x410D6E0", Offset = "0x410C4E0", VA = "0x18410D6E0")]
		public void UVUNRNLFMQU(ushort a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x410D830", Offset = "0x410C630", VA = "0x18410D830", Slot = "4")]
		protected virtual void UVUNRNLFMQU(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x410E4D0", Offset = "0x410D2D0", VA = "0x18410E4D0")]
		protected void VSOTEGGMSAS(uint a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x410D3D0", Offset = "0x410C1D0", VA = "0x18410D3D0")]
		protected void KAHQKFWTAMG(ushort a, ushort b, a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x410D2A0", Offset = "0x410C0A0", VA = "0x18410D2A0")]
		private void JVTNJBZPSNS(uint a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x410CEF0", Offset = "0x410BCF0", VA = "0x18410CEF0")]
		protected void JGESOMCZIMA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x410D540", Offset = "0x410C340", VA = "0x18410D540")]
		protected uint NNRDXADOFDL(ushort a, ushort b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x410CED0", Offset = "0x410BCD0", VA = "0x18410CED0")]
		protected ushort HHNKXZVHBGH(uint a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x410D290", Offset = "0x410C090", VA = "0x18410D290")]
		protected ushort JGTAINZKZIA(uint a)
		{
			return default(ushort);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class KBJWQHIOEFW : YKODASZGMLW<KBJWQHIOEFW.State>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class State : MTQIKZNJYEX
		{
			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public StateTransition DZFXQWQUSQU
			{
				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public StateTransition EVUPNJTCCKW
			{
				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public StateUpdate SBCGSVQNQFZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x84418D0", Offset = "0x84406D0", VA = "0x1884418D0")]
		public void TQUMOZJLVGH(ushort a, StateTransition b, StateTransition c, StateUpdate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x84419B0", Offset = "0x84407B0", VA = "0x1884419B0")]
		public void TQUMOZJLVGH(ushort a, ushort b, StateTransition c, StateTransition d, StateUpdate e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8441A90", Offset = "0x8440890", VA = "0x188441A90")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8441AE0", Offset = "0x84408E0", VA = "0x188441AE0")]
		protected KBJWQHIOEFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class OIYXHKARRKO : KBJWQHIOEFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool FIXOAWLPASC;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xFCD270", Offset = "0xFCC070", VA = "0x180FCD270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xFCCCB0", Offset = "0xFCBAB0", VA = "0x180FCCCB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8442470", Offset = "0x8441270", VA = "0x188442470")]
		public void Initialize(ushort initialStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x84424D0", Offset = "0x84412D0", VA = "0x1884424D0")]
		public void Initialize(ushort initialStateId, ushort initialSubStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8441AE0", Offset = "0x84408E0", VA = "0x188441AE0")]
		public OIYXHKARRKO()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class IWBJWSSBQWB<a, b> : IDisposable where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal class MXLBKXFRBOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public b ZPYEUNXCKKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public b TNQRTSDCHDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public PriorityClaim BNUTWBMFIVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public List<PriorityClaim> GNAKGYHTTCT;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public MXLBKXFRBOP()
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
			[Cpp2IlInjected.Address(RVA = "0x19C77A0", Offset = "0x19C65A0", VA = "0x1819C77A0")]
			public PriorityClaim(int priority, a claim)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x5CC5100", Offset = "0x5CC3F00", VA = "0x185CC5100")]
			public bool QHKZCEVYPOY([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x5CC50F0", Offset = "0x5CC3EF0", VA = "0x185CC50F0")]
			public bool FYARWXGGEUP([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x5CC50E0", Offset = "0x5CC3EE0", VA = "0x185CC50E0", Slot = "4")]
			public int CompareTo(PriorityClaim other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x5CC5160", Offset = "0x5CC3F60", VA = "0x185CC5160", Slot = "3")]
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
		private sealed class XYQTBPLGKNJ : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private b KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private b XIXWKIPXZNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public b KQIWWSZGEKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public IWBJWSSBQWB<a, b> SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private b OJILAZJKPFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public b RYMNNTZETMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private bool BFXUDPZGNWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public bool KYMQQYQNUXH;

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			private b EDWIPKOIAKW
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
			[DebuggerHidden]
			public XYQTBPLGKNJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x40A7F00", Offset = "0x40A6D00", VA = "0x1840A7F00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x402B990", Offset = "0x402A790", VA = "0x18402B990", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x40A7FE0", Offset = "0x40A6DE0", VA = "0x1840A7FE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> URCJAEQXNRT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x40A80B0", Offset = "0x40A6EB0", VA = "0x1840A80B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly OCPHBKXAICE<MXLBKXFRBOP> WKFSAKHYXAR;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly OCPHBKXAICE<List<PriorityClaim>> ZZIFKWWPXNH;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static int CKLFRZFWCYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		internal readonly Dictionary<a, b> IUCMSDQSIYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		internal readonly Dictionary<b, MXLBKXFRBOP> VFRKMGVJXLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mode SVFAXAEUJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool RKZVTHIHIQI;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract b EKKQROJHUBH(b a);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void RISOPTVCHKN(b a, a b, a c);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x51EE5D0", Offset = "0x51ED3D0", VA = "0x1851EE5D0")]
		public IWBJWSSBQWB(Mode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x51ED8F0", Offset = "0x51EC6F0", VA = "0x1851ED8F0")]
		public void PEMQHSBHVCC(b a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x51EE210", Offset = "0x51ED010", VA = "0x1851EE210")]
		public void XFIBNTWBOXO(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x51ECE80", Offset = "0x51EBC80", VA = "0x1851ECE80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x51EE180", Offset = "0x51ECF80", VA = "0x1851EE180")]
		private void VSDZNRGZBHD(a a, b b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x51EE410", Offset = "0x51ED210", VA = "0x1851EE410")]
		private int YIQTTLMQQFV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x51EDDC0", Offset = "0x51ECBC0", VA = "0x1851EDDC0")]
		private void VBMLFPXYBES(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x51ED800", Offset = "0x51EC600", VA = "0x1851ED800")]
		private void OZJGRUTDRBV(PriorityClaim a, MXLBKXFRBOP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x51ED160", Offset = "0x51EBF60", VA = "0x1851ED160")]
		private void GHWTBBIACLK(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x51ED970", Offset = "0x51EC770", VA = "0x1851ED970")]
		private void SGQCFPCXWSB(PriorityClaim a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x51EE350", Offset = "0x51ED150", VA = "0x1851EE350")]
		private void YAKNAAGMXPL(PriorityClaim a, MXLBKXFRBOP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x51EDCC0", Offset = "0x51ECAC0", VA = "0x1851EDCC0")]
		private void TNDKXMMWECE(MXLBKXFRBOP a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x51ED430", Offset = "0x51EC230", VA = "0x1851ED430")]
		private void MJILMYEHBQS(MXLBKXFRBOP a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x51ED730", Offset = "0x51EC530", VA = "0x1851ED730")]
		[IteratorStateMachine(typeof(IWBJWSSBQWB<, >.XYQTBPLGKNJ))]
		private IEnumerable<b> OSLTFHOMSCI(b a, b b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x51ECCD0", Offset = "0x51EBAD0", VA = "0x1851ECCD0")]
		private MXLBKXFRBOP BVQMKBFRSMQ(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x51ED030", Offset = "0x51EBE30", VA = "0x1851ED030")]
		private MXLBKXFRBOP GGKZZPEPZZZ(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x51ECB80", Offset = "0x51EB980", VA = "0x1851ECB80")]
		private void BGXKXNFICLR(MXLBKXFRBOP a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TCOEQWISCPX<a> : IEnumerable<TCOEQWISCPX<a>.Pair>, IEnumerable
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
		public class IRNJRGBDQIJ : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private TCOEQWISCPX<a> QJHIZFGJESD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private int VEJGVBBERIR;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x51EB9A0", Offset = "0x51EA7A0", VA = "0x1851EB9A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x51EBE00", Offset = "0x51EAC00", VA = "0x1851EBE00", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x51EBAE0", Offset = "0x51EA8E0", VA = "0x1851EBAE0")]
			public IRNJRGBDQIJ(TCOEQWISCPX<a> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x51EB870", Offset = "0x51EA670", VA = "0x1851EB870", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x499B5A0", Offset = "0x499A3A0", VA = "0x18499B5A0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xFCB1A0", Offset = "0xFC9FA0", VA = "0x180FCB1A0", Slot = "5")]
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
		private const int SAJXMEYOGHL = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly Dictionary<a, int> VXSWMAIAEBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ListEntry[] AIMSDCZAINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int HUVUNJBHPHK;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int BHMMSJOULZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAC5E20", Offset = "0xAC4C20", VA = "0x180AC5E20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xF654B0", Offset = "0xF642B0", VA = "0x180F654B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int DODEZUTZSIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C8570", Offset = "0x52C7370", VA = "0x1852C8570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x60E7BE0", Offset = "0x60E69E0", VA = "0x1860E7BE0")]
		public TCOEQWISCPX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x60E8030", Offset = "0x60E6E30", VA = "0x1860E8030")]
		public TCOEQWISCPX(Pair[] a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x60E7210", Offset = "0x60E6010", VA = "0x1860E7210")]
		public int MQEMAWVKKVY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x60E6FC0", Offset = "0x60E5DC0", VA = "0x1860E6FC0")]
		private int JLXECHMGYAR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x60E72A0", Offset = "0x60E60A0", VA = "0x1860E72A0", Slot = "6")]
		protected virtual uint PLHGOBMYRTX(uint a, a b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x60E7AE0", Offset = "0x60E68E0", VA = "0x1860E7AE0")]
		public bool ZSACCMAQVKP(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x60E7640", Offset = "0x60E6440", VA = "0x1860E7640")]
		public int SGTSCXIDATZ(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x60E77D0", Offset = "0x60E65D0", VA = "0x1860E77D0")]
		public a ZLWBNEVTNHE(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x60E6330", Offset = "0x60E5130", VA = "0x1860E6330")]
		public bool HUHLLCKKILF(a a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x60E6030", Offset = "0x60E4E30", VA = "0x1860E6030")]
		public bool HUHLLCKKILF(a a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x60E73F0", Offset = "0x60E61F0", VA = "0x1860E73F0")]
		private int SFBQNWAJZRE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x60E7710", Offset = "0x60E6510", VA = "0x1860E7710", Slot = "5")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x60E7710", Offset = "0x60E6510", VA = "0x1860E7710", Slot = "4")]
		private IEnumerator<Pair> TCKMKFVALDS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class OCPHBKXAICE<a> : IDisposable where a : new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Stack<a> JGJSDIYYXLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<a> JWGANJHPNXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly int LLFIWEKFQXG;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5B57740", Offset = "0x5B56540", VA = "0x185B57740")]
		public static OCPHBKXAICE<a> YOHUWCLVSVE(int a = 0, int b = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5B577E0", Offset = "0x5B565E0", VA = "0x185B577E0")]
		public OCPHBKXAICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5B57A20", Offset = "0x5B56820", VA = "0x185B57A20")]
		public OCPHBKXAICE(int a, int b = 2147483647, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5B567D0", Offset = "0x5B555D0", VA = "0x185B567D0")]
		public a Acquire()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5B57300", Offset = "0x5B56100", VA = "0x185B57300")]
		public void Release(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5B575C0", Offset = "0x5B563C0", VA = "0x185B575C0")]
		private void TWUHDMYPYJZ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5B57010", Offset = "0x5B55E10", VA = "0x185B57010")]
		private void QGKZYZESNTS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5B56980", Offset = "0x5B55780", VA = "0x185B56980", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5B56E20", Offset = "0x5B55C20", VA = "0x185B56E20")]
		private void JLISOADIKYZ(IEnumerable<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class FSZAHCDSNCE<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private Dictionary<int, a> CAYAUAREPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private a IIAHVFDOXKF;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual a BFYKGOLDHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xAF9280", Offset = "0xAF8080", VA = "0x180AF9280", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1441570", Offset = "0x1440370", VA = "0x181441570", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4F3CD90", Offset = "0x4F3BB90", VA = "0x184F3CD90")]
		public bool PBDIQNIYPJN(a a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4F3CF30", Offset = "0x4F3BD30", VA = "0x184F3CF30")]
		public bool XCHDUAHDCQA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x4F3C870", Offset = "0x4F3B670", VA = "0x184F3C870")]
		public a NAHFLDOVJAG(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4F3C500", Offset = "0x4F3B300", VA = "0x184F3C500")]
		private bool JFTFWGHPABY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4F3C430", Offset = "0x4F3B230", VA = "0x184F3C430")]
		public bool HHYTRHIEAWJ(int a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4F3D0D0", Offset = "0x4F3BED0", VA = "0x184F3D0D0")]
		public FSZAHCDSNCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class HSWDKYCBUJP<a>
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
		protected readonly List<Entry> JREFBMVTJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private a YXXCOENNOXQ;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int DODEZUTZSIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xB4B2C0", Offset = "0xB4A0C0", VA = "0x180B4B2C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x511D2C0", Offset = "0x511C0C0", VA = "0x18511D2C0")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x511C8C0", Offset = "0x511B6C0", VA = "0x18511C8C0")]
		public void Add(a value, int priority)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x511E180", Offset = "0x511CF80", VA = "0x18511E180")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x511D260", Offset = "0x511C060", VA = "0x18511D260")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x511DBE0", Offset = "0x511C9E0", VA = "0x18511DBE0")]
		public a DUAVQRBFMEU()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x511CEF0", Offset = "0x511BCF0", VA = "0x18511CEF0")]
		protected void BINQYYOMVOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x511E310", Offset = "0x511D110", VA = "0x18511E310")]
		public HSWDKYCBUJP()
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
			[Cpp2IlInjected.Address(RVA = "0x8442720", Offset = "0x8441520", VA = "0x188442720")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x84429F0", Offset = "0x84417F0", VA = "0x1884429F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x8442900", Offset = "0x8441700", VA = "0x188442900")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8442670", Offset = "0x8441470", VA = "0x188442670")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x8442940", Offset = "0x8441740", VA = "0x188442940")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x8442850", Offset = "0x8441650", VA = "0x188442850")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x84425E0", Offset = "0x84413E0", VA = "0x1884425E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FB5A70", Offset = "0x5FB4870", VA = "0x185FB5A70", Slot = "4")]
		public virtual T FVNGFKEJQEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected ResourcePrefabReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface YKDYZTOZSQD
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		ToolHierarchyCache UXOCAJTYRSO
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
			[Cpp2IlInjected.Address(RVA = "0x1B29B00", Offset = "0x1B28900", VA = "0x181B29B00")]
			public Enumerable(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x4981EF0", Offset = "0x4980CF0", VA = "0x184981EF0")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x4981FF0", Offset = "0x4980DF0", VA = "0x184981FF0", Slot = "5")]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x4981FF0", Offset = "0x4980DF0", VA = "0x184981FF0", Slot = "4")]
			private IEnumerator<T> HRBGLFUMDTX()
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
				[Cpp2IlInjected.Address(RVA = "0x4A2F980", Offset = "0x4A2E780", VA = "0x184A2F980", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x4A2F2D0", Offset = "0x4A2E0D0", VA = "0x184A2F2D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x4A2F570", Offset = "0x4A2E370", VA = "0x184A2F570")]
			public Enumerator(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x4A2E1F0", Offset = "0x4A2CFF0", VA = "0x184A2E1F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x4A2F160", Offset = "0x4A2DF60", VA = "0x184A2F160", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x49827D0", Offset = "0x49815D0", VA = "0x1849827D0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> VKNQKWEAKVO;

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
		private Dictionary<Type, List<Component>> GERAZPYBYHK;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x8444540", Offset = "0x8443340", VA = "0x188444540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8444340", Offset = "0x8443140", VA = "0x188444340")]
		private void Initialize(GameObject go, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x84442B0", Offset = "0x84430B0", VA = "0x1884442B0")]
		public static void Initialize(GameObject go, ToolHierarchyCache cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x84444A0", Offset = "0x84432A0", VA = "0x1884444A0")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A0A0", Offset = "0x3D48EA0", VA = "0x183D4A0A0")]
		public void QUAHGIBORDF<a>(Action<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3D49CE0", Offset = "0x3D48AE0", VA = "0x183D49CE0")]
		public b MAUEMZTMLCU<b>(bool a = false) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3D49C30", Offset = "0x3D48A30", VA = "0x183D49C30")]
		public Enumerable<c> ETPLEOWIVSR<c>(bool a = false) where c : class
		{
			return default(Enumerable<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8443E40", Offset = "0x8442C40", VA = "0x188443E40")]
		public List<Component> BFSXYSECJUQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x84441C0", Offset = "0x8442FC0", VA = "0x1884441C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache x, ToolHierarchyCache y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8444240", Offset = "0x8443040", VA = "0x188444240", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache obj)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class UJNFOLPAOXT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private int JAXKMUNLECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int SJQSUOHCCVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private List<a> DUWZPLPNRCW;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int DODEZUTZSIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x296A030", Offset = "0x2968E30", VA = "0x18296A030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public a XYTCBKNEVMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x62DCF40", Offset = "0x62DBD40", VA = "0x1862DCF40")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public a MQJQFLNTNCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x62DC8E0", Offset = "0x62DB6E0", VA = "0x1862DC8E0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public a VSWGDISKUVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x62DCB50", Offset = "0x62DB950", VA = "0x1862DCB50")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x62DCFE0", Offset = "0x62DBDE0", VA = "0x1862DCFE0")]
		public UJNFOLPAOXT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x62DC3C0", Offset = "0x62DB1C0", VA = "0x1862DC3C0")]
		public void Add(a command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x62DC960", Offset = "0x62DB760", VA = "0x1862DC960")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x62DCD50", Offset = "0x62DBB50", VA = "0x1862DCD50")]
		public void OVYIJNENCWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x62DC390", Offset = "0x62DB190", VA = "0x1862DC390")]
		public void ASOOFPDJBCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x62DCFD0", Offset = "0x62DBDD0", VA = "0x1862DCFD0")]
		public void TRSFJHMIFFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x62DC2D0", Offset = "0x62DB0D0", VA = "0x1862DC2D0")]
		public List<a> ACWYPZCVGGK()
		{
			return null;
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class NQNQZWLKRCV<a>
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
		private readonly Dictionary<object, PrioritizedData> CAYAUAREPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly EqualityComparer<a> QQZBQKHXGZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private a IIAHVFDOXKF;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual a BFYKGOLDHJI
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xF29BE0", Offset = "0xF289E0", VA = "0x180F29BE0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x5A37740", Offset = "0x5A36540", VA = "0x185A37740", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool ZFBZPIWPIYU
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x5A36640", Offset = "0x5A35440", VA = "0x185A36640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public object BTJUTEAUWLI
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xAA58C0", Offset = "0xAA46C0", VA = "0x180AA58C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5A37590", Offset = "0x5A36390", VA = "0x185A37590")]
		public bool PBDIQNIYPJN(a a, object b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5A37770", Offset = "0x5A36570", VA = "0x185A37770")]
		public bool XCHDUAHDCQA(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5A33750", Offset = "0x5A32550", VA = "0x185A33750")]
		public bool HHYTRHIEAWJ(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5A333F0", Offset = "0x5A321F0", VA = "0x185A333F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5A34C10", Offset = "0x5A33A10", VA = "0x185A34C10")]
		private bool JFTFWGHPABY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5A39860", Offset = "0x5A38660", VA = "0x185A39860")]
		public NQNQZWLKRCV()
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
