// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Video.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Video
    {

        /// <summary>
        /// Gets or sets audioBitsPerSample.
        /// Number of audio bits per sample.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audioBitsPerSample", Required = Newtonsoft.Json.Required.Default)]
        public Int32? AudioBitsPerSample { get; set; }
    
        /// <summary>
        /// Gets or sets audioChannels.
        /// Number of audio channels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audioChannels", Required = Newtonsoft.Json.Required.Default)]
        public Int32? AudioChannels { get; set; }
    
        /// <summary>
        /// Gets or sets audioFormat.
        /// Name of the audio format (AAC, MP3, etc.).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audioFormat", Required = Newtonsoft.Json.Required.Default)]
        public string AudioFormat { get; set; }
    
        /// <summary>
        /// Gets or sets audioSamplesPerSecond.
        /// Number of audio samples per second.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audioSamplesPerSecond", Required = Newtonsoft.Json.Required.Default)]
        public Int32? AudioSamplesPerSecond { get; set; }
    
        /// <summary>
        /// Gets or sets bitrate.
        /// Bit rate of the video in bits per second.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bitrate", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Bitrate { get; set; }
    
        /// <summary>
        /// Gets or sets duration.
        /// Duration of the file in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duration", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Duration { get; set; }
    
        /// <summary>
        /// Gets or sets fourCC.
        /// 'Four character code' name of the video format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fourCC", Required = Newtonsoft.Json.Required.Default)]
        public string FourCC { get; set; }
    
        /// <summary>
        /// Gets or sets frameRate.
        /// Frame rate of the video.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "frameRate", Required = Newtonsoft.Json.Required.Default)]
        public double? FrameRate { get; set; }
    
        /// <summary>
        /// Gets or sets height.
        /// Height of the video, in pixels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "height", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Height { get; set; }
    
        /// <summary>
        /// Gets or sets width.
        /// Width of the video, in pixels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "width", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Width { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
