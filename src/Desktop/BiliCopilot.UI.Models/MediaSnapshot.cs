// Copyright (c) Bili Copilot. All rights reserved.

using BiliCopilot.UI.Models.Constants;
using Richasy.BiliKernel.Models.Media;

namespace BiliCopilot.UI.Models;

/// <summary>
/// 视频快照.
/// </summary>
public sealed class MediaSnapshot
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaSnapshot"/> class.
    /// </summary>
    public MediaSnapshot(
        VideoInformation video,
        bool isPrivate = false,
        bool forceOpenInNewWindow = false)
    {
        Video = video;
        Type = BiliMediaType.Video;
        IsPrivate = isPrivate;
        ForceOpenInNewWindow = forceOpenInNewWindow;
    }

    public MediaSnapshot(
        SeasonInformation? season,
        EpisodeInformation? episode,
        bool forceOpenInNewWindow = false)
    {
        Season = season;
        Episode = episode;
        Type = BiliMediaType.Pgc;
        IsPrivate = false;
        ForceOpenInNewWindow = forceOpenInNewWindow;
    }

    /// <summary>
    /// 视频信息.
    /// </summary>
    public VideoInformation? Video { get; }

    /// <summary>
    /// 电视剧.
    /// </summary>
    public SeasonInformation? Season { get; set; }

    /// <summary>
    /// 剧集.
    /// </summary>
    public EpisodeInformation? Episode { get; set; }

    /// <summary>
    /// 无痕播放（不上报历史记录）.
    /// </summary>
    public bool IsPrivate { get; }

    /// <summary>
    /// 强制在新窗口打开.
    /// </summary>
    public bool ForceOpenInNewWindow { get; }

    /// <summary>
    /// 媒体类型.
    /// </summary>
    public BiliMediaType Type { get; set; }

    /// <summary>
    /// 偏好的清晰度.
    /// </summary>
    public int? PreferQuality { get; set; }

    /// <summary>
    /// 偏好的起始位置（秒）.
    /// </summary>
    public double? StartPosition { get; set; }

    /// <summary>
    /// 偏好的分P.
    /// </summary>
    public VideoPart? PreferPart { get; set; }

    /// <summary>
    /// 播放列表.
    /// </summary>
    public List<MediaSnapshot>? Playlist { get; set; }
}
